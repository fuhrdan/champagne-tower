//*****************************************************************************
//** 799. Champagne Tower                                           leetcode **
//*****************************************************************************
//** We pour the tower till crystal rims overflow with boast,
//** Each glass spills half its joy in shimmering toast;
//** Row by row the excess finds its careful way,
//** Till one bright cup stands full and we raise champagne to the array.
//*****************************************************************************


double champagneTower(int poured, int query_row, int query_glass){
    double f[102][102] = {0.0};
    int i;
    int j;

    f[0][0] = (double)poured;

    for (i = 0; i <= query_row; i++)
    {
        for (j = 0; j <= i; j++)
        {
            if (f[i][j] > 1.0)
            {
                double half = (f[i][j] - 1.0) / 2.0;
                f[i][j] = 1.0;
                f[i + 1][j] += half;
                f[i + 1][j + 1] += half;
            }
        }
    }

    return f[query_row][query_glass];
}