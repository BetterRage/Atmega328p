#include <avr/io.h>
#include "../Header/mydelay.h"

uint8_t get4bit();
void delay(uint32_t ms);

int main(void)
{
    DDRD=0xFF;
    DDRC=0x00;        //A0 bis A3 auf Eingang
    PORTC=0x0F;       //A0 bis A3 auf HIGH um PU Widerstand einzuschalten
    uint8_t ziffern[10]={0b11110111,0b10100100,0b11011101,0b11101101,0b10101110,0b11101011,0b11111011,0b10100111,0b11111111,0b11101111};
    uint8_t zahl=0;
    uint8_t wuerfelstopp=0;
    PORTD=0x00;
    while(1)
    {
        if(PINC&1)
        {
            delay(35);
            while(PINC&1);
            wuerfelstopp^=1;
        }
        if(wuerfelstopp)
            PORTD=ziffern[zahl++];









    }
    return 0;
}


