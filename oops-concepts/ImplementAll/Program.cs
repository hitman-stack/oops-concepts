using System;
using System.Collections.Generic;

namespace ImplementAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters=
            new List<Promoter>(){
                new XSClubPromoter("John","Doe",123456789),
                new XSClubPromoter("Jackie","Chan",857656866),
                new OmniaClubPromoter("Ben","Cleng",6865665666)
            };

            foreach(var promoter in promoters)
            {
                promoter.Promote();

            }

            List<Writer> writers=
            new List<Writer>(){
                new BookWriter("John","Doe"),
                new BookWriter("Jackie","Chan"),
                new BlogWriter("Ben","Cleng")
            };
                        foreach(var writer in writers)
            {
                writer.Write();

            }
            List<IBodyBuilder> bodyBuilders=
            new List<IBodyBuilder>(){
                 new XSClubPromoter("John","Doe",123456789),
                new XSClubPromoter("Jackie","Chan",857656866),
            };

                        foreach(var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.Workout();

            }
            List<IVlogger> vloggers=
            new List<IVlogger>(){
                 new XSClubPromoter("John","Doe",123456789),
                new BookWriter("Jackie","Chan")
            };

                        foreach(var vlogger in vloggers)
            {
                vlogger.Vlog();

            }

            
        }
    }
}
