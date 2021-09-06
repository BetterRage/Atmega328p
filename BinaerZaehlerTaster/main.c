#include <avr/io.h>
#include "Delay1174.h"
#define  F_CPU 16000000UL

int main(void)
{
    DDRC=0x00;
    //PORTC=0x01;
    DDRD=0b11111100;
    uint8_t led=0x01;
    while(1)
    {
        PORTD=led<<2;
        if((PINC&0x01))
        {
            delay32(20);
            if((PINC&0x01))
                led++;
        }
    }
    return 0;
}

