#include <avr/io.h>

void delay(uint32_t ms);

int main(void)
{
    DDRD=0xFF;
    uint8_t led=1;
    uint8_t mult=1;
    while(1)
    {

        PORTD&=~PORTD;
        PORTD|=led<<1;
        if(mult)
            led*=2;
        else
            led/=2;
        if(led==1<<6)
            mult=0;
        if(led==1<<1)
            mult=1;
        delay(200);

    }


    return 0;
}
void delay(uint32_t ms)
{
    ms*=371;
    while(ms--);
}
