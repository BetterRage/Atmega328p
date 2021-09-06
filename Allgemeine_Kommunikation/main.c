/*
USART Com
Programm zur Kommunikation mit dem PC
letzte Änderung: 26.02.2021
 */

#include <avr/io.h>
#include <avr/interrupt.h>
#include "../Headerfunktionen/UART.h"
#include <string.h>
#include <stdlib.h>


char strcmd[6];

//LED PB5

ISR(USART_RX_vect)
{
    uint8_t sreg = SREG;
    SREG&=~(1<<7);
    _gets(strcmd);
    if(strcmp("PD2=1",strcmd)==0)
    {
        PORTD |= (1<<2);
        _puts(strcmd);
        _newline();
    }
    if(strcmp("PD2=0",strcmd)==0)
    {
        PORTD &= ~(1<<2);
        _puts(strcmd);
        _newline();
    }
    SREG = sreg;
}
int main(void)
{
    DDRD =0b00000100;
    init_usart(9600);
    SREG|=(1<<7);
    while(1)
    {

    }

    return 0;
}
