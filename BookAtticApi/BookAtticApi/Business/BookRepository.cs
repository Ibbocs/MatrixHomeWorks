using AutoMapper;
using BookAtticApi.Business.Services;
using BookAtticApi.Domain.Context;
using BookAtticApi.Domain.DTO;
using BookAtticApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAtticApi.Business
{
    public class BookRepository: IBookRepositoryService
    {
        private BookAtticDbcontext BookAtticDbcontext;
        private IMapper mapper;
        public BookRepository(BookAtticDbcontext _bookAtticDbcontext, IMapper _mapper)
        {
            BookAtticDbcontext= _bookAtticDbcontext;
            mapper= _mapper;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            #region cehdlerim
            //var data = (from s in BookAtticDbcontext.Books
            //           select s) as Book; // 204 xetasi

            //var data = await (from s in BookAtticDbcontext.Books
            //                  select s).FirstOrDefaultAsync();

            var data = await (from s in BookAtticDbcontext.Books
                              select new Book
                              {
                                  Id = s.Id,
                                  Name = s.Name,
                                  Page = s.Page,
                                  ReleaseDate = s.ReleaseDate,
                                  
                                  Author = s.Author,
                                  bookPublishers = s.bookPublishers
                              }).ToListAsync();
            #endregion

            var Book = await (from s in BookAtticDbcontext.Books
                              select new Book
                              {
                                  Id = s.Id,
                                  Name = s.Name,
                                  Page = s.Page,
                                  ReleaseDate = s.ReleaseDate,
                              }).ToListAsync();

            var Publisher = await (from p in BookAtticDbcontext.Publishers
                                   select new Publisher
                                   {
                                       Id = p.Id,
                                       Name = p.Name,
                                       Price = p.Price,
                                   }).ToListAsync();

            var Author = await (from a in BookAtticDbcontext.Authors
                                select new Author
                                { 
                                    Id = a.Id, 
                                    Name = a.Name, 
                                    Surname = a.Surname 
                                }).ToListAsync();

            //var data1 = mapper.Map<SellectBookDTO>(Book);
            //var data2 = mapper.Map<SellectPublisherDTO>(Publisher);
            //var data3 = mapper.Map<SellectAuthorDTO>(Author);

            var Bookd = await (from s in BookAtticDbcontext.Books
                              select new Book
                              {
                                  Id = s.Id,
                                  Name = s.Name,
                                  Page = s.Page,
                                  ReleaseDate = s.ReleaseDate,
                              }).ToListAsync();

            //var data4 = mapper.Map<SellectAllBPAInfoDTO>(Author,Book,Publisher);

            //List<SellectAllBPAInfoDTO> list = new List<SellectAllBPAInfoDTO>();
            //list.Add(data1 as SellectAllBPAInfoDTO);
            //list.Add(data2 as SellectAllBPAInfoDTO);
            //list.Add(data3 as SellectAllBPAInfoDTO);

            return data;
        }
    }
}
