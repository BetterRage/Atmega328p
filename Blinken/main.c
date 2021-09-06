#include <avr/myDelay.h>
#include <avr/io.h>
void blinken(int PORTDdavor,int DDRDdavor,int oft,int pin);
int main(void)
{
    DDRD=0b00010100;
    PORTD=0b00010100;
    delay(1000);
    blinken(PORTD,DDRD,3,2);
    PORTD=0b00010100;
    delay(1000);
    blinken(PORTD,DDRD,3,1);
    PORTD=0b00010100;
    while(1)
    ;

    return 0;
}
void blinken(int PORTDdavor,int DDRDdavor,int oft,int pin)
{
    DDRD=1<<(pin+1);
    int i;
    for(i=0;i<oft;i++)
    {
        PORTD|=(1<<(pin+1));
        delay(500);
        PORTD&=~(1<<(pin+1));
        delay(500);
    }
    DDRD=DDRDdavor;
    PORTD=PORTDdavor;
}



