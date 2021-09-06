#include <avr/io.h>
#include "../Header/mydelay.h"

uint8_t get4bit();
void delay(uint32_t ms);

int main(void)
{
    DDRD=0xFF;
    DDRC=0x00;        //A0 bis A3 auf Eingang
    PORTC=0x0F;       //A0 bis A3 auf HIGH um PU Widerstand einzuschalten
    uint8_t ziffern[10]={0b11110111,0b10100100,0b11011101,0b11101101,0b10101110,0b11101011,0b11111011,0b10100111,0b11111111,0b11101111};
    uint8_t start=9;
    uint8_t cnt=9;
    PORTD=0xFF;
    while(1)
    {
        if(get4bit()%10!=start)
        {
            start=get4bit()%10;
            cnt=start;
        }
        PORTD=ziffern[cnt--];
        delay(500);
        if(cnt==0)
            cnt=start;




    }
    return 0;
}

