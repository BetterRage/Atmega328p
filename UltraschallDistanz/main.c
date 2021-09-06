#include "../Headerfunktionen/UART.h"
#include <avr/io.h>
#include <stdlib.h>
#include <util/delay.h>

#define TRIG 3
#define ECHO 2
int main(void)
{
    char streckec[10];
    DDRD|=(1<<TRIG);
    DDRD&=~(1<<ECHO);
    uint16_t zeit;
    uint8_t strecke;
    init_usart(9600);
    OCR0A=160;
    while(1)
    {
       PORTD|= (1<<TRIG);
       TCCR0B|=1;
       while(!(TIFR0&(1<<1)));
       TCCR0B&=~(1);
       TCNT0=0;
       TIFR0|=(1<<1);
       PORTD&=~(1<<TRIG);
       while(!(PIND&(1<<ECHO)));
       TCCR1B|=1;
       while(PIND&(1<<ECHO));
       TCCR1B=0;
       zeit=TCNT1/16;
       itoa(TCNT1,streckec,10);
       _puts(streckec);
       _newline();
       TCNT1=0;
       strecke=343*zeit/1000;
       _delay_ms(200);
    }

    return 0;
}
