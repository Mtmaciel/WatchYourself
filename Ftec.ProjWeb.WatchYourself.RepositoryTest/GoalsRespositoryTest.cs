using System;
using Ftec.ProjWeb.WatchYourself.Repository.Repositorys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ftec.ProjWeb.WatchYourself.RepositoryTest
{
    [TestClass]
    public class GoalsRespositoryTest
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInicialize()
        {
            if(TestContext.TestName == "NotEmptyGoalsList"){
                TestContext.WriteLine("Inicio do teste de lista");
            }
            else {
                TestContext.WriteLine("Inicio do teste");
            }
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("fim do teste");
        }

        [TestMethod]
        [TestCategory("ValidValues")]
        [Ignore]
        [DataSource("Npgsql", "Server=localhost; Port = 5432; Database=WatchYourself; User Id=postgres; Password=Gcon123;", "goals",DataAccessMethod.Sequential)]
        public void ValidGoalsDifficultys()
        {
            string goalTitle;
            int goalDifficulty;

            TestContext.WriteLine("Consultando banco");
            goalTitle = TestContext.DataRow["title"].ToString();
            goalDifficulty = Convert.ToInt32(TestContext.DataRow["difficulty"].ToString());
            TestContext.WriteLine($"Valores Retornados:titulo->{goalTitle}; dificuldade->{goalDifficulty} ");
            Assert.IsTrue(goalDifficulty > 0 && goalDifficulty < 4);
        }

        [TestMethod]
        [TestCategory("Lists")]
        [Owner("matheus")]
        public void NotEmptyGoalsList()
        {
            TestContext.WriteLine("Consulta na lsita de Objetivos");
            var goals = GoalsRepository.List();
            TestContext.WriteLine($"Tamanho da lista de Objetivos:{goals.Count}");
            CollectionAssert.AllItemsAreNotNull(goals);
        }

        [TestMethod]
        [TestCategory("Selects")]
        public void DoesNotExistGoal()
        {
            var goal = GoalsRepository.Select(new Guid());
            Assert.IsNull(goal);
            
        }

        [Timeout(3000)]
        [TestMethod]
        public void ShowTimeout()
        {
            System.Threading.Thread.Sleep(3100);
        }

    }
}
