using MediatR;

namespace CQRSExample.Commands;

public class UpdateProductCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateProductCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }
}