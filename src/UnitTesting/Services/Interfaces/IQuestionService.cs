﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnitTesting.Domain;

namespace UnitTesting.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<IList<Question>> GetAllAsync();
        Task<Question> GetByIdAsync(Guid id);
        Task CreateAsync(Question question);
        Task CreateBulkAsync(IList<Question> questions);
        Task UpdateAsync(Question question);
        Task UpdateBulkAsync(IList<Question> questions);
        Task DeleteAsync(Question question);
        Task DeleteBulkAsync(IList<Question> questions);
    }
}
