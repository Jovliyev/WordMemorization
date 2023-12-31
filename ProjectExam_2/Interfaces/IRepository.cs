﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemorization.Utils;

namespace WordMemorization.Interfaces;

public interface IRepository<T>
{
    public Task<int> CreateAsync(T obj);
    public Task<int> UpdateAsync(long id, T editedObj);
    public Task<int> DeleteAsync(long id);
    public Task<IList<T>> GetAllAsync(PagenationParams @params);
    public Task<T> GetAsync(long id);

}
