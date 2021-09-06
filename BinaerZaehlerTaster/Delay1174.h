#ifndef DELAY1174_H
#define DELAY1174_H
void delay32(uint32_t ms)
{
    uint32_t ms32=ms*382;
    uint32_t zahl=0;
    while(zahl<ms32)
        zahl++;
}
#endif // DELAY1174_H
