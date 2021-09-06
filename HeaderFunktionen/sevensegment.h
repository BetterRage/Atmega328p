#ifndef SEVENSEGMENT_H
#define SEVENSEGMENT_H
#include <avr/io.h>

void showdigit(uint8_t digit)
/*  7 segment anzeige anschlieﬂen von links oben nach rechts unten:
    D3 D9 D8 D2 D4 D6 D5 D7                                            */
{
    PORTD=0x00;
    PORTB=0x00;
    static uint8_t ziffern[10]={0b11110111,0b10100100,0b11011101,0b11101101,0b10101110,0b11101011,0b11111011,0b10100111,0b11111111,0b11101111};
    if(ziffern[digit]&1)
    {
        PORTB|=1;
    }
    if(ziffern[digit]&1<<1)
    {
        PORTB|=1<<1;
    }
    PORTD=ziffern[digit];
}

#endif // SEVENSEGMENT_H
