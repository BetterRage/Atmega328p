#include <avr/interrupt.h>
#include "../Headerfunktionen/UART.h"
uint8_t cnt=0;
ISR(TIMER0_COMPA_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    TCNT0=0;
    cnt++;
    SREG=sreg;
}

int main(void)
{
    SREG|=(1<<7);
    OCR0A=71;
    TIMSK0|=(1<<OCIE0A);
    TCCR0B|=0x05;
    DDRD=0b00000100;
    init_usart(9600);
    while(1)
    {
        if(cnt>=11)
        {
            cnt=0;
            PORTD^=1<<PD2;
            _putch('1');
            _newline();
        }
    }
    return 0;
}

