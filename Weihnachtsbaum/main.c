#include <avr/io.h>
#define  F_CPU 16000000UL
void delay(double ms);
int main(void)
{
    DDRD=0b11111100;
    char led=0b1;
    while(1)
    {
        PORTD|=led<<2;
        delay(100);
        PORTD&=~(led<<2);
        if(led<(1<<6))
           led=led<<1;
        else
            led=1;
    }
    return 0;
}
void delay(double ms)
{
    ms*=11.73;
    while(ms>=0)
        ms--;
    return;
}
