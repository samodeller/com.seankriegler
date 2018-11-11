using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seankriegler.Stats.Api.Utilities
{
    /// <summary>
    /// Class contains all calculations for services
    /// Defense
    /// Goalie Games Won Percentage = Games Won / (Games Won + Games Lost) 
    /// Goalie Saves = Shots on Goal - Goal Scored
    /// Saves Percentage = Goalie Saves / Shots on Goal
    /// Saves Ratio = Shots On Goal / Goalie Saves
    /// Offense
    /// Scoring Percentage = (Scoring Attempts - Goals Scored ) / Scoring Attempts
    /// Scoring Ratio = Shots On Goal / Goals Scored
    /// Games Won Percentage = Team Games Won / ( Team Games Won + Team Games Lost )
    /// </summary>
    public class Calculations
    {
        private void test()SoSt(Soccer, saves, sogsat, dsog, scores, gwon, glost, gwlp, goalssc, savesrat, osrat, savesper, pgwon, pglost, pgwlp, osp)
        {



            // define initial values



            var sogsat = 0;

            var osp = 0;

            var dsog = 0;

            var goalssc = 0;

            var scores = 0;

            var pgwon = 0;

            var pglost = 0;

            var pgwlp = 0;

            var gwon = 0;

            var glost = 0;

            var gwlp = 0;

            var savesrat = 0;

            var savesper = 0;

            var osrat = 0;



            (saves) = (eval(Soccer.dsog.value) - eval(Soccer.goalssc.value));

            Soccer.saves.value = eval(saves);

            // goalie saves



            if (eval(Soccer.dsog.value) > 0)
            {

                (savesper) = (eval(Soccer.dsog.value) + eval(Soccer.goalssc.value)) / eval(Soccer.dsog.value);

                Soccer.savesper.value = perRound(eval(savesper));

            }



            if (eval(Soccer.dsog.value) == 0)
            {

                (savesper) = 0;

                Soccer.savesper.value = 0;

            }

            // Goalie saves percentage



            if (eval(Soccer.sogsat.value) > 0)
            {

                Soccer.osp.value = perRound((eval(Soccer.sogsat.value) - eval(Soccer.scores.value)) / eval(Soccer.sogsat.value));

            }



            if (eval(Soccer.sogsat.value) == 0)
            {

                Soccer.osp.value = 0;

            }

            // Offensive scoring percentage



            if (eval(Soccer.scores.value) > 0)
            {

                Soccer.osrat.value = "1 in " + perRound(eval(Soccer.sogsat.value) / eval(Soccer.scores.value));

            }



            if (eval(Soccer.scores.value) == 0)
            {

                Soccer.osrat.value = 0;

            }

            // offensive scoring ratio



            if (eval(Soccer.gwon.value) + eval(Soccer.glost.value) > 0)
            {

                Soccer.gwlp.value = perRound(eval(Soccer.gwon.value) / (eval(Soccer.gwon.value) + eval(Soccer.glost.value)));

            }



            if (eval(Soccer.gwon.value) + eval(Soccer.glost.value) == 0)
            {

                Soccer.gwlp.value = 0;

            }

            // team games won percentage



            if (eval(Soccer.pgwon.value) + eval(Soccer.pglost.value) > 0)
            {

                Soccer.pgwlp.value = perRound(eval(Soccer.pgwon.value) / (eval(Soccer.pgwon.value) + eval(Soccer.pglost.value)));

            }



            if (eval(Soccer.pgwon.value) + eval(Soccer.pglost.value) == 0)
            {

                Soccer.pgwlp.value = 0;

            }

            // Goalie games won percentage



            if (eval(saves) > 0)
            {

                Soccer.savesrat.value = "1 in " + perRound(eval(Soccer.dsog.value) / eval(saves));

            }



            if (eval(saves) == 0)
            {

                Soccer.savesrat.value = 0;

            }

            // goalie saves ratio





        }
    }
}
