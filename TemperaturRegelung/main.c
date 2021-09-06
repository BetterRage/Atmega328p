/*
 */
#include "../Headerfunktionen/UART.h"
#include <util/delay.h>
#include <avr/interrupt.h>
#include <stdlib.h>
#include <avr/io.h>
//OC0A=PD6
//OC0B=PD5
volatile uint8_t senden=0;
char spga[5]={0,0,0,0,0};
ISR(TIMER1_COMPA_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    if(senden==1)
    {
        _puts(spga);
        _newline();
    }

    SREG=sreg;
}
ISR(USART_RX_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    uint8_t input=_getch();
    switch (input)
    {
        case 'b':   senden=0;
                    break;
        case 's':   senden=1;
                    break;
    }
    SREG=sreg;
}
int main(void)
{
    SREG|=(1<<7);
    init_usart(9600);
    uint16_t adcval;
    uint8_t adcscal;
    DDRD|=(0b11<<5);
    /// //////////////////////////////////////////////////////////////PWM
    TCCR0A=0b10100011; //clear OC0A und OC0B bei match, Fast PWM mode
    TCCR0B=0b00000001; //kein Prescaler
    /// //////////////////////////////////////////////////////////////Delay
    TCCR1B=0b00001101; // CTC Mode
    OCR1A=7812;
    TIMSK1|=(1<<1);
    /// /////////////////////////////////////////////////////////////ADC
    ADCSRA=0b11110111;
    ADCSRB=0b00000000;
    /// //////////////////////////////////////////////////////////////
    while(1)
    {
        while(!(ADCSRA&(1<<ADIF)));
        ADCSRA|=(1<<ADIF);
        adcval=ADC;
        adcscal=(255.0/400.0)*(((adcval<263)?(263):(adcval>663)?663:adcval)-263);
        OCR0B=adcscal;
        OCR0A=255-adcscal;
        itoa(adcval,spga,10);

    }

    return 0;
}
