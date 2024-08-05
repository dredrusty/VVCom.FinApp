using FinGo.DataAccess.Interfaces;

namespace FinGo.DataAccess.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    ICategoryRepository CategoryRepository { get; }

    ICommentRepository CommentRepository { get; }

    ICredentialRepository CredentialRepository { get; }

    IOperationRepository OperationRepository { get; }

    IRoleRepository RoleRepository { get; }

    IUserRepository UserRepository { get; }

    IWalletRepository WalletRepository { get; }

    IRepositoryBase<TEntity> GetRepository<TEntity>()
        where TEntity : class;

    void Commit();
}