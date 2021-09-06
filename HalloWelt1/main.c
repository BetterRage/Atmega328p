#include <avr/io.h>
void delay(double ms);
int main(void)
{
    DDRD = 0x94; //0 eingang 1 ausgang
    while(1)
    {
        PORTD = 0x94;
        delay(10000);
        PORTD = 0x00;
        delay(10000);

    }
    return 0;
}
void delay(double ms)
{
    ms*=11.74;
    while(ms>=0)
        ms--;
    return;
}
