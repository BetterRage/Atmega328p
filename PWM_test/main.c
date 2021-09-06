#include "../Headerfunktionen/mydelay.h"
#include <avr/io.h>
#include <avr/interrupt.h>

int main(void)
{
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX=0x60;
    uint8_t x;
    DDRD|=0b11111100;
    TCCR0A=0x83;
    TIMSK0|=(1<<OCIE0A);
    OCR0A=30;
    TCCR0B=0x01;
    while(1)
    {
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        OCR0A=ADCH;
    }


    return 0;
}
