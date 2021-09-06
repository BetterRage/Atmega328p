#include <avr/interrupt.h>
#include <avr/io.h>
#include <util/delay.h>
double powh(double basis,uint8_t exponent);
void liedspielen(int8_t lied[],uint8_t noten);

int main(void)
{
    int8_t lied[]={3,5,7,8,10,-1,10,-1,12,12,12,12,10,-1,12,12,12,12,10,-1,8,8,8,8,7,-1,7,-1,5,5,5,5,3};
    uint8_t noten=sizeof(lied)/sizeof(lied[0]);
    TCCR0B|=0x05;
    TCCR0A=0b01000010;
    DDRD|=(1<<6);

    while(1)
    {
        liedspielen(lied,noten);
        _delay_ms(5000);
    }
    return 0;
}
void liedspielen(int8_t lied[],uint8_t noten)
{

    uint8_t i=0;

    double faktor=1.059463;

    for(i=0;i<noten;i++)
    {
        if(lied[i]==-1)
        {
            _delay_ms(300);
        }
        if(lied[i]!=-1)
        {
            OCR0A=15625/(440*powh(faktor,lied[i]));
            TCCR0B|=0b101;
            _delay_ms(300);
            TCCR0B=0;
        }
        _delay_ms(100);
    }
}
double powh(double basis,uint8_t exponent)
{
    uint8_t i;
    double ret=basis;
    for(i=1;i<exponent;i++)
    {
        ret*=basis;
    }
    return ret;
}

