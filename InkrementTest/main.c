#include <avr/io.h>
#include "Delay1174.h"
void delay(uint32_t ms);
int main(void)
{

    DDRD=0b00000100;
    PORTD=1<<PD2;

    while(1)
    {
        delay(3000);
        PORTD|=1<<PD2;
        delay(3000);
        PORTD&=~(1<<PD2);
    }


    return 0;
}

