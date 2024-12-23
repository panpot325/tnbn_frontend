namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Method.Generic
/// </summary>
public partial class WorkData {
    /// <summary>
    /// CreateField
    /// </summary>
    /// <returns></returns>
    private WorkData DefaultField() {
        Fsno = NewField(0, "", true);
        Fblk = NewField(1, "", true);
        Fbzi = NewField(2, "", true);
        Fpcs = NewField(3, "", true);

        Fgr1 = NewField(4, (short)0, true);
        Fgr2 = NewField(5, (short)0, true);
        Fgr3 = NewField(6, (short)0, true);
        Fgr4 = NewField(7, (short)0, true);
        Fgr5 = NewField(8, (short)0, true);

        Flk1 = NewField(9, (short)0, true);
        Flk2 = NewField(10, (short)0, true);
        Flk3 = NewField(11, (short)0, true);
        Flk4 = NewField(12, (short)0, true);
        Flk5 = NewField(13, (short)0, true);

        Fl = NewField(14, 0m, true);
        Fb = NewField(15, 0m, true);
        Ftmax = NewField(16, 0m, true);

        Ft1 = NewField(17, 0m, true);
        Ft2 = NewField(18, 0m, true);
        Ft3 = NewField(19, 0m, true);
        Ft4 = NewField(20, 0m, true);
        Ft5 = NewField(21, 0m, true);

        Fit1 = NewField(22, 0m, true);
        Fit2 = NewField(23, 0m, true);
        Fit3 = NewField(24, 0m, true);
        Fit4 = NewField(25, 0m, true);

        Fsp1 = NewField(26, 0m, true);
        Fsp2 = NewField(27, 0m, true);
        Fsp3 = NewField(28, 0m, true);
        Fsp4 = NewField(29, 0m, true);
        Fsp5 = NewField(30, 0m, true);

        Flh1 = NewField(31, 0m, true);
        Flh2 = NewField(32, 0m, true);
        Flh3 = NewField(33, 0m, true);
        Flh4 = NewField(34, 0m, true);
        Flh5 = NewField(35, 0m, true);

        Flt1 = NewField(36, 0m, true);
        Flt2 = NewField(37, 0m, true);
        Flt3 = NewField(38, 0m, true);
        Flt4 = NewField(39, 0m, true);
        Flt5 = NewField(40, 0m, true);

        Fll1 = NewField(41, 0m, true);
        Fll2 = NewField(42, 0m, true);
        Fll3 = NewField(43, 0m, true);
        Fll4 = NewField(44, 0m, true);
        Fll5 = NewField(45, 0m, true);

        Fwl1 = NewField(46, (short)0, true);
        Fwl2 = NewField(47, (short)0, true);
        Fwl3 = NewField(48, (short)0, true);
        Fwl4 = NewField(49, (short)0, true);
        Fwl5 = NewField(50, (short)0, true);

        Fis1 = NewField(51, 0m, true);

        Fstp1 = NewField(52, 0m, true);
        Fstp2 = NewField(53, 0m, true);
        Fstp3 = NewField(54, 0m, true);
        Fstp4 = NewField(55, 0m, true);
        Fstp5 = NewField(56, 0m, true);

        Forg = NewField(57, (short)0, true);
        FyoteibiKari = NewField(58, 0, true);

        return this;
    }
}