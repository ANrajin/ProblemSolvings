#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    // remove before submit
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);

    // If you think it's simple, then you have misunderstood the problem ;)
    int t;
    scanf("%d", &t);

    while (t--)
    {
        char n[100];
        scanf("%s", &n);

        int last = (int)n[strlen(n) - 1] - '0';

        if (last % 2 == 0)
            printf("even\n");
        else
            printf("odd\n");
    }

    return 0;
}