using BaseballAnalysisTool.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data.SeedData
{
    public class BaseballTeamsSeedData
    {
        public async static Task GetData(ApplicationDbContext _db)
        {
            // Country
            int countryUnitedStatesID = (await _db.Country.FirstOrDefaultAsync(x => x.Name == "United States")).ID;
            int countryCanadaID = (await _db.Country.FirstOrDefaultAsync(x => x.Name == "Canada")).ID;

            // States
            int stateTexasID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Texas")).ID ;
            int stateCaliforniaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "California")).ID;
            int stateWashingtonID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Washington")).ID;
            int stateMassachusettsID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Massachusetts")).ID;
            int stateNewYorkID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "New York")).ID;
            int stateMarylandID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Maryland")).ID;
            int stateFloridaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Florida")).ID;
            int stateIllinoisID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Illinois")).ID;
            int stateOhioID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Ohio")).ID;
            int stateMichiganID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Michigan")).ID;
            int stateMissouriID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Missouri")).ID;
            int stateMinnesotaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Minnesota")).ID;
            int statePennsylvaniaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Pennsylvania")).ID;
            int stateGeorgiaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Georgia")).ID;
            int stateWisconsinID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Georgia")).ID;
            int stateArizonaID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Arizona")).ID;
            int stateColoradoID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Colorado")).ID;
            int stateWashingtonDcID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "District of Columbia")).ID;
            int stateOntarioID = (await _db.StateOrProvinces.FirstOrDefaultAsync(x => x.Name == "Ontario (CA)")).ID;

            // Baseball Division
            int divisionAmericanLeagueEastID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "American League East")).ID;
            int divisionAmericanLeagueCentralID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "American League Central")).ID;
            int divisionAmericanLeagueWestID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "American League West")).ID;
            int divisionNationalLeagueEastID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "National League East")).ID;
            int divisionNationalLeagueCentralID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "National League Central")).ID;
            int divisionNationalLeagueWestID = (await _db.BaseballDivisions.FirstOrDefaultAsync(x => x.Name == "National League East")).ID;

            // Baseball League
            int leagueAmericanID = (await _db.BaseballLeagues.FirstOrDefaultAsync(x => x.Name == "American League")).ID;
            int leagueNationalID = (await _db.BaseballLeagues.FirstOrDefaultAsync(x => x.Name == "National League")).ID;

            var baseballTeams = new BaseballTeam[]
            {
                // American East
                new BaseballTeam{Location="Boston", NickName="Red Sox", StadiumName="Fenway Park", City="Boston", TeamLogoImagePath="/images/defaultTeamLogo/red_sox.png", StateOrProvinceID=stateMassachusettsID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueEastID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="New York", NickName="Yankees", StadiumName="Yankee Stadium", City="New York", TeamLogoImagePath="/images/defaultTeamLogo/yankees.png", StateOrProvinceID=stateNewYorkID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueEastID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Baltimore", NickName="Orioles", StadiumName="Oriole Park at Camden Yards", TeamLogoImagePath="/images/defaultTeamLogo/orioles.png", City="Baltimore", StateOrProvinceID=stateMarylandID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueEastID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Tampa Bay", NickName="Rays", StadiumName="Tropicana Field", City="Tampa Bay", TeamLogoImagePath="/images/defaultTeamLogo/rays.png", StateOrProvinceID=stateFloridaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueEastID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Toronto", NickName="Blue Jays", StadiumName="Rogers Centre", City="Toronto", TeamLogoImagePath="/images/defaultTeamLogo/blue_jays.png", StateOrProvinceID=stateOntarioID, CountryID=countryCanadaID, BaseballDivisionID=divisionAmericanLeagueEastID, BaseballLeagueID=leagueAmericanID},

                // American Central
                new BaseballTeam{Location="Chicago", NickName="White Sox", StadiumName="Guaranteed Rate Field", City="Chicago", TeamLogoImagePath="/images/defaultTeamLogo/white_sox.png", StateOrProvinceID=stateIllinoisID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueCentralID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Cleveland", NickName="Indians", StadiumName="Progressive Field", City="Ohio", TeamLogoImagePath="/images/defaultTeamLogo/indians.png", StateOrProvinceID=stateOhioID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueCentralID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Detroit", NickName="Tigers", StadiumName="Comerica Park", City="Detroit", TeamLogoImagePath="/images/defaultTeamLogo/tigers.png", StateOrProvinceID=stateMichiganID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueCentralID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Kansas City", NickName="Royals", StadiumName="Kauffman Stadium", City="Kansas City", TeamLogoImagePath="/images/defaultTeamLogo/royals.png", StateOrProvinceID=stateMissouriID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueCentralID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Minnesota", NickName="Twins", StadiumName="Target Field", City="Minneapolis", TeamLogoImagePath="/images/defaultTeamLogo/twins.png", StateOrProvinceID=stateMinnesotaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueCentralID, BaseballLeagueID=leagueAmericanID},

                
                // American West
                new BaseballTeam{Location="Houston", NickName="Astros", StadiumName="Minute Maid Park", City="Houston", TeamLogoImagePath="/images/defaultTeamLogo/astros.png", StateOrProvinceID=stateTexasID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueWestID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Texas", NickName="Rangers", StadiumName="Globe Life Field", City="Dallas", TeamLogoImagePath="/images/defaultTeamLogo/rangers.png", StateOrProvinceID=stateTexasID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueWestID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Los Angeles", NickName="Angels", StadiumName="Angel Stadium", City="Los Angeles", TeamLogoImagePath="/images/defaultTeamLogo/angels.png", StateOrProvinceID=stateCaliforniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueWestID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Oakland", NickName="Athletics", StadiumName="RingCentral Coliseum", City="Oakland", TeamLogoImagePath="/images/defaultTeamLogo/athletics.png", StateOrProvinceID=stateCaliforniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueWestID, BaseballLeagueID=leagueAmericanID},
                new BaseballTeam{Location="Seattle", NickName="Mariners", StadiumName="T-Mobile Park", City="Seattle", TeamLogoImagePath="/images/defaultTeamLogo/mariners.png", StateOrProvinceID=stateWashingtonID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionAmericanLeagueWestID, BaseballLeagueID=leagueAmericanID},

                // National East
                new BaseballTeam{Location="New York", NickName="Mets", StadiumName="Citi Field", City="New York", TeamLogoImagePath="/images/defaultTeamLogo/mets.png", StateOrProvinceID=stateNewYorkID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueEastID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Miami", NickName="Marlins", StadiumName="LoanDepot Park", City="Miami", TeamLogoImagePath="/images/defaultTeamLogo/marlins.png", StateOrProvinceID=stateFloridaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueEastID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Philadephia", NickName="Phillies", StadiumName="Citizens Bank Park", City="Philadelphia", TeamLogoImagePath="/images/defaultTeamLogo/phillies.png", StateOrProvinceID=statePennsylvaniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueEastID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Washington", NickName="Nationals", StadiumName="Nationals Park", City="Washington", TeamLogoImagePath="/images/defaultTeamLogo/nationals.png", StateOrProvinceID=stateWashingtonDcID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueEastID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Atlanta", NickName="Braves", StadiumName="Truist Park", City="Atlanta", TeamLogoImagePath="/images/defaultTeamLogo/braves.png", StateOrProvinceID=stateGeorgiaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueEastID, BaseballLeagueID=leagueNationalID},

                // National Central
                new BaseballTeam{Location="Cincinnati", NickName="Reds", StadiumName="Great American Ball Park", City="Cincinnati", TeamLogoImagePath="/images/defaultTeamLogo/reds.png", StateOrProvinceID=stateOhioID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueCentralID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Milwaukee", NickName="Brewers", StadiumName="American Family Field", City="Milwaukee", TeamLogoImagePath="/images/defaultTeamLogo/brewers.png", StateOrProvinceID=stateWisconsinID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueCentralID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="St. Louis", NickName="Cardinals", StadiumName="Busch Stadium", City="St. Louis", TeamLogoImagePath="/images/defaultTeamLogo/cardinals.png", StateOrProvinceID=stateMissouriID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueCentralID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Chicago", NickName="Cubs", StadiumName="Wrigley Field", City="Chicago", TeamLogoImagePath="/images/defaultTeamLogo/cubs.png", StateOrProvinceID=stateIllinoisID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueCentralID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Pittsburgh", NickName="Pirates", StadiumName="PNC Park", City="Pittsburgh", TeamLogoImagePath="/images/defaultTeamLogo/pirates.png", StateOrProvinceID=statePennsylvaniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueCentralID, BaseballLeagueID=leagueNationalID},

                // National West
                new BaseballTeam{Location="Los Angeles", NickName="Dodgers", StadiumName="Dodger Stadium", City="Los Angeles", TeamLogoImagePath="/images/defaultTeamLogo/dodgers.png", StateOrProvinceID=stateCaliforniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueWestID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="San Francisco", NickName="Giants", StadiumName="Oracle Park", City="San Francisco", TeamLogoImagePath="/images/defaultTeamLogo/giants.png", StateOrProvinceID=stateCaliforniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueWestID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="San Diego", NickName="Padres", StadiumName="Petco Park", City="San Diego", TeamLogoImagePath="/images/defaultTeamLogo/padres.png", StateOrProvinceID=stateCaliforniaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueWestID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Arizona", NickName="Diamondbacks", StadiumName="Chase Field", City="Phoenix", TeamLogoImagePath="/images/defaultTeamLogo/diamondbacks.png", StateOrProvinceID=stateArizonaID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueWestID, BaseballLeagueID=leagueNationalID},
                new BaseballTeam{Location="Colorado", NickName="Rockies", StadiumName="Coors Field", City="Denver", TeamLogoImagePath="/images/defaultTeamLogo/rockies.png", StateOrProvinceID=stateColoradoID, CountryID=countryUnitedStatesID, BaseballDivisionID=divisionNationalLeagueWestID, BaseballLeagueID=leagueNationalID},
            };

            _db.BaseballTeam.AddRange(baseballTeams);
            _db.SaveChanges();


        }
    }
}
