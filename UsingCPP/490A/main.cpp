#include <iostream>
#include <vector>
#include <bits/stdc++.h>

using namespace std;

int main()
{
    int n;
    cin >> n;
    vector<int> prog, math, pe;

    for (int i = 1; i <= n; i++)
    {
        int x;
        cin >> x;

        if (x == 1)
        {
            prog.push_back(i);
            continue;
        }
        else if (x == 2)
        {
            math.push_back(i);
            continue;
        }
        else if (x == 3)
        {
            pe.push_back(i);
            continue;
        }
    }

    int totalTeam = min(prog.size(), min(math.size(), pe.size()));
    cout << totalTeam;
    cout << endl;

    for (int i = 0; i < totalTeam; i++)
    {
        printf("%d %d %d \n", prog[i], math[i], pe[i]);
    }

    return 0;
}
