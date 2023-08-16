namespace Bookify.Application.Bookings.ReserveBooking;

internal sealed class ReserveBookingCommandHandler : ICommandHandler<ReserveBookingCommand, Guid>
{
    private readonly IUserRepository _userRepository;
    private readonly IApartmentRepository _apartmentRepository;
    private readonly IBookingRepository _bookingRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly PricingService _pricingService;
    
    public async Task<Result<Guid>> Handle(ReserveBookingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}