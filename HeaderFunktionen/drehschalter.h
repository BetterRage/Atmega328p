#ifndef DREHSCHALTER_H_INCLUDED
#define DREHSCHALTER_H_INCLUDED
#include <avr/io.h>

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

#endif // DREHSCHALTER_H_INCLUDED
