# [Small To Large](https://lightoj.com/problem/dimik-small-to-large)

```
#include <bits/stdc++.h>

using namespace std;

//function Prototype
void swap(int, int, int);

int main()
{
    int t, cs = 1;
    scanf("%d", &t);

    while(t--)
    {
        int a, b, c;
        scanf("%d%d%d", &a, &b, &c);

        while(a > b || b > c)
        {
            swap(a, b, c);
        }

        printf("Case %d: %d %d %d\n", cs++,a, b, c);
    }
    return 0;
}

void swap(int &x, int &y, int &z)
{
    int temp;
    if(x > y)
    {
        temp = y;
        y = x;
        x = temp;
    }

    if(y > z)
    {
        temp = z;
        z = y;
        y = temp;
    }
}

```
