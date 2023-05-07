namespace FireApp.Models;

public class Driver
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    /// <summary>
    /// 驱动编号
    /// </summary>
    public int DriverNumber { get; set; }
    public int Status { get; set; }
}
