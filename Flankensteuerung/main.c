#include "../HeaderFunktionen/mydelay.h"
#include "../HeaderFunktionen/pinauslesen.h"
#include <avr/io.h>
#include <util/delay.h>

int main(void)
{

    DDRB|=(1<<1);
    DDRC&=~1;
    PORTC|=1;
    uint8_t tasterjetzt=0;
    uint8_t tasterdavor=1;
    uint8_t puls=0;
    TCCR1B|=(1<<3);
    OCR1A=1500;
    TCCR1A=0b01000000;

    while(1)
    {

        tasterjetzt=pinlesen(0);
        _delay_ms(5);
        if(tasterjetzt&&!tasterdavor)
        {
            if(puls==1)
                TCCR1B|=0b101;

            if(puls==0)
                TCCR1B&=~(0b111);
            puls^=1;
        }
        tasterdavor=tasterjetzt;
    }
    return 0;
}

