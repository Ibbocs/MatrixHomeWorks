namespace MovieLibraryAPI.MyTask
{
    public class Task
    {
        /*
         1.Movie Library API using .NET Core and EF Core istifade ederem MovieLibraryApi yaradin.
         Istifadecilere film siyahisi idare edilmesi teqdim edir.Model Movie(film) olacaq ve Actors olacaq
         Movie - classin propertyleri-title,release year,genre,director,aktyorlari
         Actors   -Adi
         Movie ve Actors classlari arasinda elageni duzgun qurmaga calishin.
         
         Servisinizde asagidaki endpointler olmalidi.
         GET /movies - filmerin siyahisi getirsin.
         GET /movies/{id} - ID ye uygun filmi getirsin
         POST /movies - yeni film yaratsin.
         PUT /movies/{id} - movcud filmi update edir
         DELETE /movies/{id} -movcud filmi silir.
         
         GET /actors GET /actors/{id}
         POST /actors 
         PUT /actors/{id} 
         DELETE /actors/{id} 
         
         GET /movies/{id}/actors -verilen filmin aktyorlarinin siyahisi
         POST /movies/{id}/actors - verilen filme aktyor elave edilmesi
         DELETE /movies/{id}/actors/{actorId} - verilen filmden aktyor silinmesi.
         GET /movies/search?title={title}&actor={actorName} - filmin adi ve aktyor adina gore tapmaq
         
         Error handlin prosesine onem verin.Xeta mesajlari olsun mutleg shekilde.
         Mapper,DTO,duzgun adlandirma folder sistemine ve database -e fikir verin

        */
    }
}
