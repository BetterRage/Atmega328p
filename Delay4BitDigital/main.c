#include <avr/io.h>
#include "../Header/delay.h"

uint8_t get4bit();
void delay(uint32_t ms);

int main(void)
{
    DDRD=1<<PD2;
    DDRC=0b00000000;        //A0 bis A3 auf Eingang
    PORTC=0b00001111;       //A0 bis A3 auf HIGH um PU Widerstand einzuschalten
    while(1)
    {
        PORTD|=1<<PD2;
        delay(get4bit()*67);
        PORTD&=~1<<PD2;
        delay(get4bit()*67);
    }
    return 0;
}

uint8_t get4bit()     //gibt Wert zwischen 0 und 15 zurück je nach Position des Schalters
{
    uint8_t schalter=0;
    int i;
    for(i=0;i<4;i++)
    {
        if(!(PINC&1<<i))
            schalter+=1<<i;
    }
    return schalter;
}
