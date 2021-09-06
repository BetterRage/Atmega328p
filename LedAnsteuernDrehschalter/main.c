#include <avr/io.h>

void delay(uint32_t ms);
uint8_t get4bit();

int main(void)
{
    DDRD=0b00111100;
    DDRC=0b00000000;
    PORTC=0b00001111;
    uint8_t led=0;
    while(1)
    {
        led=1<<((get4bit()%4)+2);
        if(led!=PORTD)
        {
            PORTD=1<<((get4bit()%4)+2);
        }
    }
    return 0;
}
uint8_t get4bit()     //gibt Wert zwischen 0 und 15 zurück je nach Position des Schalters
{
    uint8_t schalter=0;
    int i;
    for(i=0;i<4;i++)
    {
        if(!(PINC&1<<i))
            schalter+=1<<i;
    }
    return schalter;
}
void delay(uint32_t ms)
{
    ms*=371;
    while(ms--);
}
