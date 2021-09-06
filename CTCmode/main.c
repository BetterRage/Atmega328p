#include <avr/interrupt.h>
#include <string.h>
#include "../HeaderFunktionen/UART.h"
#include "../HeaderFunktionen/mydelay.h"
char spgs[10];
char input[10];
uint8_t send=0;
ISR(USART_RX_vect)  //daten senden in 50ms Schritten
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    _gets(input);
    if(strcmp(input,"on")==0)
    {
       send=1;
       PORTD|=(1<<5);
    }
    else if(strcmp(input,"off")==0)
    {
        send=0;
        PORTD&=~(1<<5);
    }
    SREG=sreg;
}
ISR(TIMER1_COMPA_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    if(send==1)
    {
        _puts("On");
        _newline();
    }

    if(send==0)
    {
        _puts("Off");
        _newline();
    }

    SREG=sreg;

}
int main(void)
{
    //
    init_usart(9600);
    DDRD|=(1<<5);
    //interrupts freischalten
    SREG|=(1<<7);
    TIMSK1|=(1<<1);
    //16 bit timer für delays
    TCCR1A = 0x00;
    TCCR1B = 0x0B;  //pre scaler 64, TCCRB1 Bit 3 auf 1 setzen -> 0000 1011 -> 0x0B
    OCR1A=10000;
    TCNT1=0;
    //adc wandler
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX=0x40;
    ADCSRA|=(1<<ADSC);  //Konvertierung starten damit bei der ersten Ausführung der ISR ein Wert bereit ist
    while(1)
    {


        delay(1000);

    }

}
