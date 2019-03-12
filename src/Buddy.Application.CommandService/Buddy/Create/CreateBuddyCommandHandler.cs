﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain;
using MediatR;

namespace Buddy.Application.CommandService.Buddy.Create
{
    public class CreateBuddyCommandHandler: INotificationHandler<CreateBuddyCommand>
    {
        private readonly IRepository _repository;

        public CreateBuddyCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBuddyCommand notification, CancellationToken cancellationToken)
        {
            var buddyId = Guid.NewGuid().ToString();
            var buddy = await _repository.GetById<Domain.Entities.Buddy>(buddyId);
            buddy.Create(buddyId, notification.AccountId);
            await _repository.Save(buddy);
        }
    }
}
