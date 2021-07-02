using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Repository
{
    public class Word
    {
        public WordOption WordChoice { get; set; }

        public Word(WordOption wordChoice)
        {
            WordChoice = wordChoice;
        }
        public Word() { }
    }
    public enum WordOption
    {
        day = 1,
        distance,
        park,
        invent,
        raise,
        magic,
        trains,
        ban,
        window,
        drown,
        ambiguous,
        babies,
        deserve,
        actor,
        loving,
        narrow,
        hushed,
        pine,
        dogs,
        acrid,
        button,
        flagrant,
        whirl,
        attach,
        guard,
        suggest,
        plausible,
        power,
        piquant,
        boil,
        kindhearted,
        sip,
        unruly,
        marry,
        rainy,
        nondescript,
        dark,
        foregoing,
        income,
        extralarge,
        card,
        wine,
        sponge,
        business,
        reaction,
        white,
        erratic,
        sky,
        extrasmall,
        relation,
        encouraging,
        cracker,
        lacking,
        splendid,
        gullible,
        relax,
        wacky,
        fasten,
        sassy,
        mass,
        unhealthy,
        lumber,
        arm,
        run,
        judge,
        flawless,
        maid,
        launch,
        lie,
        care,
        poke,
        omniscient,
        colorful,
        previous,
        ski,
        waves,
        spare,
        shy,
        coor,
        dinated,
        lake,
        unbiased,
        complete,
        thin,
        separate,
        range,
        comb,
        absurd,
        defeated,
        grieving,
        half,
        stone,
        sprout,
        giddy,
        sweet,
        suspend,
        rampant,
        reward,
        eggs,
        vacation,
        brake
    }
    
}
