using LibraryCore.Domain.Abstract;
using LibraryCore.Domain.Entities;
using System;

namespace LibraryCore.Factories
{
    public static class Kernel
    {
        public static IUnitOfWork Db { get; set; }
        public static User AuthenticatedUser { get; set; }
    }
}
