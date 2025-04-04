﻿using Server.DataAccess.Database;
using Server.DataAccess.Repository.Abstraction;
using Server.DataAccess.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _context;
        public IUserRepository userRepository { get; private set; }
        public IDetailsRepository detailsRepository { get; private set; }
        public IPhotoRepository photoRepository { get; private set; }
        public ILikeRepository likeRepository { get; private set; }
        public IMatchRepository matchRepository { get; private set; }

        public UnitOfWork(ApplicationDBContext context) {
            this._context = context;
            this.userRepository = new UserRepository(context);
            this.detailsRepository = new DetailsRepository(context);
            this.photoRepository = new PhotoRepository(context);
            this.likeRepository = new LikeRepository(context);
            this.matchRepository = new MatchRepository(context);
        }

        public async Task SaveTransaction()
        {
            await this._context.SaveChangesAsync();
        }        
    }
}
