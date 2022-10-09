#include <iostream>

using namespace std;

int main()
{
    long long n, m, l, x;
    cin >> n;

    if (n >= 2)
    {
        l = 0;
        m = 1;
        while (m <= n / 2)
        {
            x = n - m;
            if (x % m == 0)
                l = l + 1;

            m++;
        }
    }

    cout << l;

    return 0;
}