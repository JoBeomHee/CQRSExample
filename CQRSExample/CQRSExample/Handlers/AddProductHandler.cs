using CQRSExample.Commands;
using CQRSExample.Repository;
using MediatR;

namespace CQRSExample.Handlers;

public class AddProductHandler : IRequestHandler<AddProductCommand>
{
    private readonly FakeDataStore _fakeDataStore;

    public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

    public async Task Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        //var validator = new CreateProductCommandValidator();
        //var validationResult = await validator.ValidateAsync(request);

        //if (validationResult.Errors.Any())
        //    throw new Exception("I);

        await _fakeDataStore.AddProduct(request.Product);
        return;
    }
}
