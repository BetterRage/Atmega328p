#ifndef DELAY1174_H
#define DELAY1174_H
void delay(double ms)
{
    ms*=11.73;
    while(ms>=0)
        ms--;
    return;
}
#endif // DELAY1174_H
