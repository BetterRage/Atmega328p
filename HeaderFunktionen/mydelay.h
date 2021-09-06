#ifndef MYDELAY_H_INCLUDED
#define MYDELAY_H_INCLUDED
#include <avr/io.h>

void delay(uint32_t ms)
{
    ms*=371;
    while(ms--);
}
#endif // MYDELAY_H_INCLUDED
