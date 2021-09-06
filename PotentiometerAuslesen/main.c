#include "../Headerfunktionen/UART.h"
#include "../Headerfunktionen/mydelay.h"
#include <avr/io.h>
#include <stdlib.h>
int main(void)      //AVCC = 4,524
{
    uint8_t x;
    char str[4];
    ADCSRA|=0x07; //Freque
    ADCSRA|=(1<<ADEN);
    ADMUX=0x60;
    init_usart(9600);
    while(1)
    {
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        x=ADCH;
        itoa(x,str,10);
        _puts(str);
        _newline();
        delay(50);
    }
    return 0;
}

