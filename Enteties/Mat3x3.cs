namespace ADO_task1
{
    public class Mat3x3
    {
        public Vec3 Row1 { get; }
        public Vec3 Row2 { get; }
        public Vec3 Row3 { get; }
        public Mat3x3(Vec3 row1, Vec3 row2, Vec3 row3)
        {
            Row1 = row1;
            Row2 = row2;
            Row3 = row3;
        }
        public Mat3x3(Mat3x3 copyMat3x3) : this(copyMat3x3.Row1, copyMat3x3.Row2, copyMat3x3.Row3) { }
    }
}
