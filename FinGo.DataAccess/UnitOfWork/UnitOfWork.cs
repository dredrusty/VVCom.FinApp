using FinGo.DataAccess.Interfaces;
using FinGo.DataBase;
using FinGo.DataBase.Models;

namespace FinGo.DataAccess.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly FinGoContext _context;

    private readonly Dictionary<Type, object> registry = [];

    public ICategoryRepository CategoryRepository { get; init; }

    public ICommentRepository CommentRepository { get; init; }

    public ICredentialRepository CredentialRepository { get; init; }

    public IOperationRepository OperationRepository { get; init; }

    public IRoleRepository RoleRepository { get; init; }

    public IUserRepository UserRepository { get; init; }

    public IWalletRepository WalletRepository { get; init; }

    public UnitOfWork(
        FinGoContext context,
        ICategoryRepository categoryRepository,
        ICommentRepository commentRepository,
        ICredentialRepository credentialRepository,
        IOperationRepository operationRepository,
        IRoleRepository roleRepository,
        IUserRepository userRepository,
        IWalletRepository walletRepository)
    {
        _context = context;

        CategoryRepository = categoryRepository;

        registry.Add(typeof(Category), CategoryRepository);

        CommentRepository = commentRepository;

        registry.Add(typeof(Comment), CommentRepository);

        CredentialRepository = credentialRepository;

        registry.Add(typeof(Credential), CredentialRepository);

        OperationRepository = operationRepository;

        registry.Add(typeof(Operation), OperationRepository);

        RoleRepository = roleRepository;

        registry.Add(typeof(Role), RoleRepository);

        UserRepository = userRepository;

        registry.Add(typeof(User), UserRepository);

        WalletRepository = walletRepository;

        registry.Add(typeof(Wallet), WalletRepository);
    }

    public IRepositoryBase<TEntity> GetRepository<TEntity>()
        where TEntity : class    
            => (IRepositoryBase<TEntity>)registry[typeof(TEntity)];

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}