#include "../Headerfunktionen/mydelay.h"
#include "../Headerfunktionen/UART.h"
#include <avr/io.h>
#include <stdlib.h>
#define uint uint8_t

int main(void)
{
    ADMUX=0x40;
    ADCSRA|=0x07;
    ADCSRA|=1<<ADEN;
    DDRD=1<<2;

    uint16_t spg;
    while(1)
    {
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        spg=ADC;
        delay(50);
        (spg>907)?(PORTD=1<<2):(spg<680)?(PORTD=0):(PORTD=PORTD);
    }


    return 0;
}
