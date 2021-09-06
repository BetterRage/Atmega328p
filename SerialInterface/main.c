#include <avr/io.h>
#include <stdlib.h>
#include "../Header/drehschalter.h"
#include "../Header/UART.h"
#include "../Header/mydelay.h"

int main(void)
{
    DDRD = 0b00000000;
    PORTD = 0b11111111;
    DDRC = 0b00000000;
    PORTC = 0b00101111;
    char str[3];
    init_usart();
    while(1)
    {
        if(PINC & (1<<PC5))
        {
            itoa(get4bit(),str,10);
            _puts(str);
            delay(100);
        }
    }
    return 0;
}
