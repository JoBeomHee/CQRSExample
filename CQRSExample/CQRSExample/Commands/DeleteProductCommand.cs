using MediatR;

namespace CQRSExample.Commands;

public class DeleteProductCommand : IRequest<int>
{
    public int Id { get; set; }

    public DeleteProductCommand(int id)
    {
        Id = id;
    }
}
