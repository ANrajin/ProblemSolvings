#include <iostream>
#include <math.h>

using namespace std;

int main()
{
    long t, n, x, f;

    cin >> t;

    while (t--)
    {
        cin >> n >> x;
        f = 1;

        if (n > 2)
        {
            n -= 2;
            f += n % x == 0 ? ceil(n / x) : (ceil(n / x) + 1);
        }

        cout << f << endl;
    }

    return 0;
}
