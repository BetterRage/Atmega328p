#include "../../Headerfunktionen/UART.h"
#include "../../Headerfunktionen/mydelay.h"
#include <avr/io.h>

int main(void)
{
    DDRD=0b00011100;
    init_usart();
    while(1)
    {
        if((UCSR0A & (1<<UDRE0)))
        {
            PORTD=1<<(UDR0-48);
        }
    }

    return 0;
}
