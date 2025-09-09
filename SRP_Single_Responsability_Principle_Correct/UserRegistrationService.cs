using System.Numerics;

namespace SRP_Single_Responsability_Principle_Correct;

/// <summary>
/// Responsabilidad única: Coordinar el proceso de registro de usuarios.
/// </summary>
public class UserRegistrationService
{
    //  readonly (C#) = final (java)
    private readonly UserValidator _userValidator;
    private readonly UserRepository _userRepository;
    private readonly EmailService _emailService;
    private readonly UserReportService _userReportService;

    public UserRegistrationService(UserValidator userValidator,
                                   UserRepository userRepository, 
                                   EmailService emailService,
                                   UserReportService userReportService)
    {
        _userValidator = userValidator;
        _userRepository = userRepository;
        _emailService = emailService;
        _userReportService = userReportService;
    }

    public bool RegisterUser(User user)
    {
        if (!_userValidator.IsValid(user))
        {
            return false;
        }

        _userRepository.Save(user);
        _emailService.SendWelcomeEmail(user);
        _userReportService.GenerateReport(user);

        return true;
    }    
}
