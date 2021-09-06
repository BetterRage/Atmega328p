#include <avr/io.h>

void delay(uint32_t ms)
{
    ms*=371;
    while(ms--);
}
