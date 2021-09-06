//#include "lcd.h"
#include <avr/interrupt.h>
#include <string.h>
#include "../HeaderFunktionen/UART.h"
uint8_t mscount50=0;
char spgs[10];
ISR(TIMER2_COMPA_vect)  //daten senden in 50ms Schritten
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    mscount50++;
    if(mscount50>=10)
    {
        itoa8(ADC,spgs);    //Wert vom letzten Mal umwandeln und senden
//        lcd_clrscr();
//        lcd_puts(spgs);
        strcat(spgs," 1023");
        _puts(spgs);
        _newline();
        ADCSRA|=(1<<ADSC);  //Konvertierung starten damit in 50ms ein neuer Wert bereit ist
        mscount50=0;
    }
    SREG=sreg;
}
int main(void)
{

    uint8_t warten=0;
    //
    init_usart(9600);
    DDRD|=(1<<6);
    //interrupts freischalten
    SREG|=(1<<7);
    TIMSK2|=(1<<OCIE2A);
    //8 bit timer für PWM Signal
    TCCR0A=0x83;
    OCR0A=0;
    TCCR0B=0x01;
    TCNT0=0;
    //8 bit timer 50ms delay
    TCCR2A |= (1 << WGM21);
    TCCR2B=0b00000111;
    OCR2A=71;
    TCNT2=0;
    //16 bit timer für delays
    TCCR1B=0b00001101;
    TCCR1A=0;
    uint8_t cnttime=0;
    TCNT1=0;

//    lcd_init(LCD_DISP_ON);
//    lcd_clrscr();
    //adc wandler
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX=0x40;
    ADCSRA|=(1<<ADSC);  //Konvertierung starten damit bei der ersten Ausführung der ISR ein Wert bereit ist
    while(1)
    {
        //spg. über 7 sekunden erhöhen
        if(!warten)
        {
            OCR1A=4375;
            while(cnttime<25)
            {
                if(TIFR1&(1<<1))
                {
                    //TCNT1=0;
                    TIFR1|=(1<<1);
                    OCR0A+=9;
                    cnttime++;
                }
            }
            cnttime=0;
            //6 sek. warten
            OCR1A=3750;
            while(cnttime<25)
            {
                if(TIFR1&(1<<1))
                {
                    //TCNT1=0;
                    TIFR1|=(1<<1);
                    cnttime++;
                }
            }
            OCR0A=111;
        }

        //warten bis die spg. 2V erreicht
        warten=1;
        if(!(ADCSRA&(1<<ADSC)))
           if((ADC>>2)==112)
                warten=0;
        if(!warten)
        {
            cnttime=0;
            //5 sek. warten
            OCR1A=3125;
            while(cnttime<25)
            {
                if(TIFR1&(1<<1))
                {
                    //TCNT1=0;
                    TIFR1|=(1<<1);
                    cnttime++;
                }
            }
            cnttime=0;
            OCR0A=0;
            //5 sek. warten
            while(cnttime<25)
            {
                if(TIFR1&(1<<1))
                {
                    //TCNT1=0;
                    TIFR1|=(1<<1);
                    cnttime++;
                }
            }
            cnttime=0;
        }
    }
    return 0;
}





