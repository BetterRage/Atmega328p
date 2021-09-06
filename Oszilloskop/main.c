#include "../Headerfunktionen/UART.h"
#include "../Headerfunktionen/mydelay.h"
#include <avr/io.h>
#include <avr/interrupt.h>
unsigned char spgc[5];
ISR(USART_RX_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    if(UDR0==49)
    {
        PORTD|=1<<2;
        _puts(spgc);
        _newline();
    }
    SREG=sreg;
}
int main(void)
{
    uint16_t spg;
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX|=0x40;
    SREG|=(1<<7);
    init_usart(19200);
    while(1)
    {
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        spg=ADC;
        itoa8(spg,spgc);
    }


    return 0;
}

