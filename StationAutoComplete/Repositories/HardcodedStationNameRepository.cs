﻿using System;
using System.Collections.Generic;

namespace StationAutoComplete.Repositories {
	public class HardcodedStationNameRepository : IStationNameRepository {
		private List<string> _stationNames;

		public IEnumerable<string> GetStationNames() {
			return ALL_STATION_NAMES;
		}

		private static string[] ALL_STATION_NAMES = @"Abbey Wood, Aber, Abercynon, Aberdare, Aberdeen, Aberdour, Aberdovey, Abererch, Abergavenny,
Abergele & Pensarn, Aberystwyth, Accrington, Achanalt, Achnasheen, Achnashellach, Acklington,
Acle, Acocks Green, Acton Bridge, Acton Central, Acton Main Line, Adderley Park, Addiewell,
Addlestone, Adisham, Adlington(Cheshire), Adlington(Lancashire), Adwick, Aigburth, Ainsdale,
Aintree, Airbles, Airdrie, Albany Park, Albrighton, Alderley Edge, Aldermaston, Aldershot, Aldrington,
Alexandra Palace, Alexandra Parade, Alexandria, Alfreton, Allen's West, Alloa, Alness, Alnmouth,
Alresford, Alsager, Althorne, Althorpe, Altnabreac, Alton, Altrincham, Alvechurch, Ambergate,
Amberley, Amersham, Ammanford, Ancaster, Anderston, Andover, Anerley, Angel Road, Angmering,
Annan, Anniesland, Ansdell & Fairhaven, Appleby, Appledore, Appleford, Appley Bridge, Apsley,
Arbroath, Ardgay, Ardlui, Ardrossan Harbour, Ardrossan South Beach, Ardrossan Town, Ardwick,
Argyle Street, Arisaig, Arlesey, Armadale, Armathwaite, Arnside, Arram, Arrochar & Tarbet, Arundel,
Ascot, Ascott-Under-Wychwood, Ash, Ash Vale, Ashburys, Ashchurch, Ashfield, Ashford (Middlesex),
Ashford International, Ashley, Ashtead, Ashton-Under-Lyne, Ashurst, Ashurst New Forest, Ashwell &
Morden, Askam, Aslockton, Aspatria, Aspley Guise, Aston, Atherstone, Atherton, Attadale,
Attenborough, Attleborough, Auchinleck, Audley End, Aughton Park, Aviemore, Avoncliff,
Avonmouth, Axminster, Aylesbury, Aylesbury Vale Parkway, Aylesford, Aylesham, Ayr, Bache,
Baglan, Bagshot, Baildon, Baillieston, Balcombe, Baldock, Balham, Balloch, Balmossie, Bamber
Bridge, Bamford, Banavie, Banbury, Bangor(Gwynedd), Bank Hall, Banstead, Barassie, Bardon Mill,
Bare Lane, Bargeddie, Bargoed, Barking, Barming, Barmouth, Barnehurst, Barnes, Barnes Bridge,
Barnetby, Barnham, Barnhill, Barnsley, Barnstaple, Barnt Green, Barrhead, Barrhill, Barrow Haven,
Barrow-In-Furness, Barrow-Upon-Soar, Barry, Barry Docks, Barry Island, Barry Links, Barton-OnHumber,
Basildon, Basingstoke, Bat & Ball, Bath Spa, Bathgate, Batley, Battersby, Battersea Park,
Battle, Battlesbridge, Bayford, Beaconsfield, Bearley, Bearsden, Bearsted, Beasdale, Beaulieu Road,
Beauly, Bebington, Beccles, Beckenham Hill, Beckenham Junction, Bedford Midland, Bedford
St.Johns, Bedhampton, Bedminster, Bedworth, Bedwyn, Beeston, Bekesbourne, Belle Vue, Bellgrove,
Bellingham, Bellshill, Belmont, Belper, Beltring, Belvedere, Bempton, Ben Rhydding, Benfleet,
Bentham, Bentley, Bentley (S.Yorks), Bere Alston, Bere Ferrers, Berkhamsted, Berkswell, Berney
Arms, Berry Brow, Berrylands, Berwick (Sussex), Berwick-Upon-Tweed, Bescar Lane, Bescot Stadium,
Betchworth, Bethnal Green, Betws-y-Coed, Beverley, Bexhill, Bexley, Bexleyheath, Bicester North,
Bicester Town, Bickley, Bidston, Biggleswade, Bilbrook, Billericay, Billingham, Billingshurst, Bingham,
Bingley, Birchgrove, Birchington-On-Sea, Birchwood, Birkbeck, Birkdale, Birkenhead Central,
Birkenhead Hamilton Square, Birkenhead North, Birkenhead Park, Birmingham Bordesley,
Birmingham International, Birmingham Moor Street, Birmingham New Street, Birmingham Snow Hill,
Bishop Auckland, Bishopbriggs, Bishops Stortford, Bishopstone, Bishopton, Bitterne, Blackburn,
Blackfriars, Blackheath, Blackhorse Road, Blackpool North, Blackpool Pleasure Beach, Blackpool
South, Blackridge, Blackrod, Blackwater, Blaenau Ffestiniog, Blair Atholl, Blairhill, Blake Street,
Blakedown, Blantyre, Blaydon, Bleasby, Bletchley, Bloxwich, Bloxwich North, Blundellsands & Crosby,
Blythe Bridge, Bodmin Parkway, Bodorgan, Bognor Regis, Bogston, Bolton, Bolton-On-Dearne,
Bookham, Bootle (Cumbria), Bootle New Strand, Bootle Oriel Road, Borough Green & Wrotham,
Borth, Bosham, Boston, Botley, Bottesford, Bourne End, Bournemouth, Bournville, Bow Brickhill,
Bowes Park, Bowling, Boxhill & Westhumble, Bracknell, Bradford Forster Square, Bradford
Interchange, Bradford-On-Avon, Brading, Braintree, Braintree Freeport, Bramhall, Bramley
(Hampshire), Bramley (West Yorkshire), Brampton (Cumbria), Brampton (Suffolk), Branchton,
Brandon, Branksome, Braystones, Bredbury, Breich, Brentford, Brentwood, Bricket Wood, Bridge Of
Allan, Bridge Of Orchy, Bridgend, Bridgeton, Bridgwater, Bridlington, Brierfield, Brigg, Brighouse,
Brighton, Brimsdown, Brinnington, Bristol Parkway, Bristol Temple Meads, Brithdir, British Steel
Redcar, Briton Ferry, Brixton, Broad Green, Broadbottom, Broadstairs, Brockenhurst, Brockholes,
Brockley, Bromborough, Bromborough Rake, Bromley Cross, Bromley North, Bromley South,
Bromsgrove, Brondesbury, Brondesbury Park, Brookman's Park, Brookwood, Broome, Broomfleet,
Brora, Brough, Broughty Ferry, Broxbourne, Bruce Grove, Brundall, Brundall Gardens, Brunstane,
Brunswick, Bruton, Bryn, Buckenham, Buckley, Bucknell, Buckshaw Parkway, Bugle, Builth Road,
Bulwell, Bures, Burgess Hill, Burley Park, Burley-In-Wharfedale, Burnage, Burneside, Burnham,
Burnham-On-Crouch, Burnley Barracks, Burnley Central, Burnley Manchester Road, Burnside,
Burntisland, Burscough Bridge, Burscough Junction, Bursledon, Burton Joyce, Burton-On-Trent, Bury
St.Edmunds, Busby, Bush Hill Park, Bushey, Butlers Lane, Butlins Penychain, Buxted, Buxton, Byfleet
& New Haw, Bynea, Cadoxton, Caergwrle, Caerphilly, Caersws, Caldercruix, Caldicot, Caledonian
Road & Barnsbury, Calstock, Cam & Dursley, Camberley, Camborne, Cambridge, Cambridge Heath,
Cambuslang, Camden Road, Camelon, Canada Water, Canley, Cannock, Cannon Street, Canonbury,
Canterbury East, Canterbury West, Cantley, Capenhurst, Carbis Bay, Cardenden, Cardiff Bay, Cardiff
Central, Cardiff Queen Street, Cardonald, Cardross, Carfin, Cark & Cartmel, Carlisle, Carlton, Carluke,
Carmarthen, Carmyle, Carnforth, Carnoustie, Carntyne, Carpenders Park, Carrbridge, Carshalton,
Carshalton Beeches, Carstairs, Cartsdyke, Castle Bar Park, Castle Cary, Castleford, Castleton,
Castleton Moor, Caterham, Catford, Catford Bridge, Cathays, Cathcart, Cattal, Causeland, Cefn-YBedd,
Chadwell Heath, Chafford Hundred, Chalfont & Latimer, Chalkwell, Chandlers Ford, Chapel-EnLe-Frith,
Chapelton, Chapeltown, Chappel & Wakes Colne, Charing, Charing Cross, Charing Cross
(Glasgow), Charlbury, Charlton, Chartham, Chassen Road, Chatelherault, Chatham, Chathill, Cheadle
Hulme, Cheam, Cheddington, Chelford, Chelmsford, Chelsfield, Cheltenham Spa, Chepstow, Cherry
Tree, Chertsey, Cheshunt, Chessington North, Chessington South, Chester, Chester Road, Chester-LeStreet,
Chesterfield, Chestfield & Swalecliffe, Chetnole, Chichester, Chilham, Chilworth, Chingford,
Chinley, Chippenham, Chipstead, Chirk, Chislehurst, Chiswick, Cholsey, Chorley, Chorleywood,
Christ's Hospital, Christchurch, Church & Oswaldtwistle, Church Fenton, Church Stretton, Cilmeri,
City Thameslink, Clacton, Clandon, Clapham (North Yorkshire), Clapham High Street, Clapham
Junction, Clapton, Clarbeston Road, Clarkston, Claverdon, Claygate, Cleethorpes, Cleland, Clifton,
Clifton Down, Clitheroe, Clock House, Clunderwen, Clydebank, Coatbridge Central, Coatbridge
Sunnyside, Coatdyke, Cobham & Stoke D'abernon, Codsall, Cogan, Colchester, Colchester Town,
Coleshill Parkway, Collingham, Collington, Colne, Colwall, Colwyn Bay, Combe, Commondale,
Congleton, Conisbrough, Connel Ferry, Cononley, Conway Park, Conwy, Cooden Beach, Cookham,
Cooksbridge, Coombe, Copplestone, Corbridge, Corby, Corkerhill Glasgow, Corkickle, Corpach,
Corrour, Coryton, Coseley, Cosford, Cosham, Cottingham, Cottingley, Coulsdon South, Coulsdon
Town, Coventry, Cowden, Cowdenbeath, Cradley Heath, Craigendoran, Cramlington, Craven Arms,
Crawley, Crayford, Crediton, Cressing, Cressington, Creswell (Derbys), Crewe, Crewkerne, Crews Hill,
Crianlarich, Criccieth, Cricklewood, Croftfoot, Crofton Park, Cromer, Cromford, Crookston Glasgow,
Cross Gates, Crossflatts, Crosshill, Crosskeys, Crossmyloof, Croston, Crouch Hill, Crowborough,
Crowhurst, Crowle, Crowthorne, Croy, Crystal Palace, Cuddington, Cuffley, Culham, Culrain,
Cumbernauld, Cupar, Curriehill, Cuxton, Cwmbach, Cwmbran, Cynghordy, Dagenham Dock, Daisy
Hill, Dalgety Bay, Dalmally, Dalmarnock, Dalmeny, Dalmuir, Dalreoch, Dalry, Dalston, Dalston
(Kingsland), Dalston Junction, Dalton, Dalwhinnie, Danby, Danescourt, Danzey, Darlington, Darnall,
Darsham, Dartford, Darton, Darwen, Datchet, Davenport, Dawlish, Dawlish Warren, Deal, Dean,
Deansgate, Deepdene, Deganwy, Deighton, Delamere, Denby Dale, Denham, Denham Golf Club,
Denmark Hill, Dent, Denton, Deptford, Derby, Derby Road, Devonport, Dewsbury, Didcot Parkway,
Digby and Sowton, Dilton Marsh, Dinas (Mid Glamorgan), Dinas Powys, Dingle Road, Dingwall,
Dinsdale, Dinting, Disley, Diss, Dockyard, Dodworth, Dolau, Doleham, Dolgarrog, Dolwyddelan,
Doncaster, Dorchester South, Dorchester West, Dore, Dorking, Dorking West, Dormans, Dorridge,
Dove Holes, Dover Priory, Dovercourt, Dovey Junction, Downham Market, Drayton Green, Drayton
Park, Drem, Driffield, Drigg, Droitwich Spa, Dronfield, Drumchapel, Drumfrochar, Drumgelloch,
Drumry, Duddeston, Dudley Port, Duffield, Duirinish, Duke Street, Dullingham, Dumbarton Central,
Dumbarton East, Dumbreck, Dumfries, Dumpton Park, Dunbar, Dunblane, Dunbridge, Duncraig,
Dundee, Dunfermline, Dunfermline Queen Margaret, Dunkeld & Birnam, Dunlop, Dunrobin Castle,
Dunston, Dunton Green, Durham, Durrington-On-Sea, Dyce, Dyffryn Ardudwy, Eaglescliffe, Ealing
Broadway, Earlestown, Earley, Earlsfield, Earlswood (Surrey), Earlswood (West Midlands), East
Croydon, East Didsbury, East Dulwich, East Farleigh, East Garforth, East Grinstead, East Kilbride, East
Malling, East Midlands Parkway, East Tilbury, East Worthing, Eastbourne, Eastbrook, Easterhouse,
Eastham Rake, Eastleigh, Eastrington, Ebbsfleet International, Ebbw Vale Parkway, Eccles, Eccles
Road, Eccleston Park, Edale, Eden Park, Edenbridge, Edenbridge Town, Edge Hill, Edinburgh,
Edinburgh Park, Edmonton Green, Effingham Junction, Eggesford, Egham, Egton, Elephant & Castle,
Elgin, Ellesmere Port, Elmers End, Elmstead Woods, Elmswell, Elsecar, Elsenham, Elstree &
Borehamwood, Eltham, Elton & Orston, Ely, Emerson Park, Emsworth, Enfield Chase, Enfield Lock,
Enfield Town, Entwistle, Epsom, Epsom Downs, Erdington, Eridge, Erith, Esher, Essex Road,
Etchingham, Euston, Euxton Balshaw Lane, Evesham, Ewell East, Ewell West, Exeter Central, Exeter
St. David's, Exeter St. Thomas, Exhibition Centre Glasgow, Exmouth, Exton, Eynsford, Fairbourne,
Fairfield, Fairlie, Fairwater, Falconwood, Falkirk Grahamston, Falkirk High, Falls Of Cruachan, Falmer,
Falmouth Docks, Falmouth Town, Fambridge, Fareham, Farnborough (Main), Farnborough North,
Farncombe, Farnham, Farningham Road, Farnworth, Farringdon, Fauldhouse, Faversham, Faygate,
Fazakerley, Fearn, Featherstone, Felixstowe, Feltham, Fenchurch Street, Feniton, Fenny Stratford,
Fernhill, Ferriby, Ferryside, Ffairfach, Filey, Filton Abbey Wood, Finchley Road & Frognal, Finsbury
Park, Finstock, Fishbourne, Fishersgate, Fishguard Harbour, Fiskerton, Fitzwilliam, Five Ways, Fleet,
Flimby, Flint, Flitwick, Flixton, Flowery Field, Folkestone Central, Folkestone West, Ford, Forest Gate,
Forest Hill, Formby, Forres, Forsinard, Fort Matilda, Fort William, Four Oaks, Foxfield, Foxton, Frant,
Fratton, Freshfield, Freshford, Frimley, Frinton, Frizinghall, Frodsham, Frome, Fulwell, Furness Vale,
Furze Platt, Gainsborough Central, Gainsborough Lea Road, Garelochhead, Garforth, Gargrave,
Garrowhill, Garscadden, Garsdale, Garston (Hertfordshire), Garswood, Gartcosh, Garth (MidGlamorgan),
Garth (Powys), Garve, Gathurst, Gatley, Gatwick Airport, Georgemas Junction, Gerrards
Cross, Gidea Park, Giffnock, Giggleswick, Gilberdyke, Gilfach Fargoed, Gillingham (Dorset),
Gillingham (Kent), Gilshochill, Gipsy Hill, Girvan, Glaisdale, Glan Conwy, Glasgow Central, Glasgow
Queen Street, Glasshoughton, Glazebrook, Gleneagles, Glenfinnan, Glengarnock, Glenrothes with
Thornton, Glossop, Gloucester, Glynde, Gobowen, Godalming, Godley, Godstone, Goldthorpe, Golf
Street, Golspie, Gomshall, Goodmayes, Goole, Goostrey, Gordon Hill, Goring & Streatley, Goring-BySea,
Gorton, Gospel Oak, Gourock, Gowerton, Goxhill, Grange Park, Grange-Over-Sands,
Grangetown (South Glamorgan), Grantham, Grateley, Gravelly Hill, Gravesend, Grays, Great Ayton,
Great Bentley, Great Chesterford, Great Coates, Great Malvern, Great Missenden, Great Yarmouth,
Green Lane, Green Road, Greenbank, Greenfaulds, Greenfield, Greenford, Greenhithe, Greenock
Central, Greenock West, Greenwich, Gretna Green, Grimsby Docks, Grimsby Town, Grindleford,
Grosmont, Grove Park, Guide Bridge, Guildford, Guiseley, Gunnersbury, Gunnislake, Gunton,
Gwersyllt, Gypsy Lane, Habrough, Hackbridge, Hackney Central, Hackney Downs, Hackney Wick,
Haddenham & Thame Parkway, Haddiscoe, Hadfield, Hadley Wood, Hag Fold, Haggerston, Hagley,
Hairmyres, Hale, Halesworth, Halewood, Halifax, Hall Green, Hall I' Th' Wood, Hall Road, Halling,
Haltwhistle, Ham Street, Hamble, Hamilton Central, Hamilton West, Hammerton, Hampden Park,
Hampstead Heath, Hampton, Hampton Court, Hampton Wick, Hampton-In-Arden, Hamstead,
Hamworthy, Handborough, Handforth, Hanwell, Hapton, Harlech, Harlesden, Harling Road,
Harlington, Harlow Mill, Harlow Town, Harold Wood, Harpenden, Harrietsham, Harringay, Harringay
Green Lanes, Harrington, Harrogate, Harrow & Wealdstone, Harrow-On-The-Hill, Hartford,
Hartlebury, Hartlepool, Hartwood, Harwich International, Harwich Town, Haslemere, Hassocks,
Hastings, Hatch End, Hatfield, Hatfield & Stainforth, Hatfield Peverel, Hathersage, Hattersley, Hatton,
Havant, Havenhouse, Haverfordwest, Hawarden, Hawarden Bridge, Hawkhead, Haydon Bridge,
Haydons Road, Hayes (Kent), Hayes & Harlington, Hayle, Haymarket, Haywards Heath, Hazel Grove,
Headcorn, Headingley, Headstone Lane, Heald Green, Healing, Heath High Level, Heath Low Level,
Heaton Chapel, Hebden Bridge, Heckington, Hedge End, Hednesford, Heighington, Helensburgh
Central, Helensburgh Upper, Hellifield, Helmsdale, Helsby, Hemel Hempstead, Hendon, Hengoed,
Henley-In-Arden, Henley-On-Thames, Hensall, Hereford, Herne Bay, Herne Hill, Hersham, Hertford
East, Hertford North, Hessle, Heswall, Hever, Heworth, Hexham, Heyford, Heysham Harbour, High
Brooms, High Street, High Wycombe, Higham, Highams Park, Highbridge & Burnham, Highbury &
Islington, Hightown, Hildenborough, Hillfoot, Hillington East, Hillington West, Hillside, Hilsea,
Hinchley Wood, Hinckley, Hindley, Hinton Admiral, Hitchin, Hither Green, Hockley, Hollingbourne,
Holmes Chapel, Holmwood, Holton Heath, Holyhead, Holytown, Homerton, Honeybourne, Honiton,
Honley, Honor Oak Park, Hook, Hooton, Hope (Clwyd), Hope (Derbyshire), Hopton Heath, Horley,
Hornbeam Park, Hornsey, Horsforth, Horsham, Horsley, Horton In Ribblesdale, Horwich Parkway,
Hoscar, Hough Green, Hounslow, Hove, Hoveton & Wroxham, How Wood (Hertfordshire), Howden,
Howwood, Hoxton, Hoylake, Hubberts Bridge, Hucknall, Huddersfield, Hull, Humphrey Park,
Huncoat, Hungerford, Hunmanby, Hunt's Cross, Huntingdon, Huntly, Hurst Green, Hutton Cranswick,
Huyton, Hyde Central, Hyde North, Hykeham, Hyndland, Hythe, IBM, Ifield, Ilford, Ilkley, Imperial
Wharf, Ince, Ince & Elton, Ingatestone, Insch, Invergordon, Invergowrie, Inverkeithing, Inverkip,
Inverness, Invershin, Inverurie, Ipswich, Irlam, Irvine, Isleworth, Islip, Iver, Ivybridge, Jewellery
Quarter, Johnston (Dyfed), Johnstone, Jordanhill, Kearsley, Kearsney, Keighley, Keith, Kelvedon,
Kelvindale, Kemble, Kempston Hardwick, Kempton Park, Kemsing, Kemsley, Kendal, Kenley, Kennett,
Kennishead, Kensal Green, Kensal Rise, Kensington Olympia, Kent House, Kentish Town, Kentish
Town West, Kenton, Kents Bank, Kettering, Kew Bridge, Kew Gardens, Keyham, Keynsham,
Kidbrooke, Kidderminster, Kidsgrove, Kidwelly, Kilburn High Road, Kildale, Kildonan, Kilgetty,
Kilmarnock, Kilmaurs, Kilpatrick, Kilwinning, Kinbrace, King's Cross, King's Langley, King's Lynn, King's
Norton, King's Nympton, King's Park, King's Sutton, Kingham, Kinghorn, Kingsknowe, Kingston,
Kingswood, Kingussie, Kintbury, Kirby Cross, Kirk Sandall, Kirkby (Merseyside), Kirkby in Ashfield,
Kirkby Stephen, Kirkby-In-Furness, Kirkcaldy, Kirkconnel, Kirkdale, Kirkham & Wesham, Kirkhill,
Kirknewton, Kirkwood, Kirton Lindsey, Kiveton Bridge, Kiveton Park, Knaresborough, Knebworth,
Knighton, Knockholt, Knottingley, Knucklas, Knutsford, Kyle Of Lochalsh, Ladybank, Ladywell,
Laindon, Lairg, Lake, Lakenheath, Lamphey, Lanark, Lancaster, Lancing, Landywood, Langbank,
Langho, Langley, Langley Green, Langley Mill, Langside, Langwathby, Langwith, Lapford, Lapworth,
Larbert, Largs, Larkhall, Laurencekirk, Lawrence Hill, Layton, Lazonby & Kirkoswald, Lea Green, Lea
Hall, Leagrave, Lealholm, Leamington Spa, Leasowe, Leatherhead, Ledbury, Lee, Leeds, Leicester,
Leigh (Kent), Leigh-On-Sea, Leighton Buzzard, Lelant, Lelant Saltings, Lenham, Lenzie, Leominster,
Letchworth, Leuchars, Levenshulme, Lewes, Lewisham, Leyland, Leyton Midland Road, Leytonstone
High Road, Lichfield City, Lichfield Trent Valley, Lidlington, Limehouse, Lincoln Central, Lingfield,
Lingwood, Linlithgow, Liphook, Liskeard, Liss, Lisvane and Thornhill, Little Kimble, Little Sutton,
Littleborough, Littlehampton, Littlehaven, Littleport, Liverpool Central, Liverpool James Street,
Liverpool Lime Street, Liverpool South Parkway, Liverpool Street, Livingston North, Livingston South,
Llanaber, Llanbedr, Llanbister Road, Llanbradach, Llandaf, Llandanwg, Llandecwyn, Llandeilo,
Llandovery, Llandrindod, Llandudno, Llandudno Junction, Llandybie, Llanelli, Llanfairfechan,
Llanfairpwll, Llangadog, Llangammarch, Llangennech, Llangynllo, Llanharan, Llanhilleth, Llanishen,
Llanrwst, Llansamlet, Llantwit Major, Llanwrda, Llanwrtyd, Llwyngwril, Llwynypia, Loch Awe, Loch Eil
Outward Bound, Lochailort, Locheilside, Lochgelly, Lochluichart, Lochwinnoch, Lockerbie, Lockwood,
London Bridge, London Fields, London Road Brighton, London Road Guildford, Long Buckby, Long
Eaton, Long Preston, Longbeck, Longbridge, Longcross, Longfield, Longniddry, Longport, Longton,
Looe, Lostock Gralam, Lostock Hall, Lostock Parkway, Lostwithiel, Loughborough, Loughborough
Junction, Lowdham, Lower Sydenham, Lowestoft, Ludlow, Luton, Luton Airport Parkway, Luxulyan,
Lydney, Lye, Lymington Pier, Lymington Town, Lympstone Commando, Lympstone Village, Lytham,
Macclesfield, Machynlleth, Maesteg, Maesteg (Ewenny Road), Maghull, Maiden Newton,
Maidenhead, Maidstone Barracks, Maidstone East, Maidstone West, Malden Manor, Mallaig,
Malton, Malvern Link, Manchester Airport, Manchester Oxford Road, Manchester Piccadilly,
Manchester Victoria, Manea, Manningtree, Manor Park, Manor Road, Manorbier, Manors, Mansfield
Town, Mansfield Woodhouse, March, Marden, Margate, Market Harborough, Market Rasen,
Markinch, Marks Tey, Marlow, Marple, Marsden, Marske, Marston Green, Martin Mill, Martins
Heron, Marton, Maryhill, Maryland, Marylebone, Maryport, Matlock, Matlock Bath, Mauldeth Road,
Maxwell Park, Maybole, Maze Hill, Meadowhall, Meldreth, Melksham, Melton, Melton Mowbray,
Menheniot, Menston, Meols, Meols Cop, Meopham, Merryton, Merstham, Merthyr Tydfil, Merthyr
Vale, Metheringham, MetroCentre, Mexborough, Micheldever, Micklefield, Middlesbrough,
Middlewood, Midgham, Milford (Surrey), Milford Haven, Mill Hill (Lancashire), Mill Hill Broadway,
Millbrook (Bedfordshire), Millbrook (Hampshire), Milliken Park, Millom, Mills Hill, Milngavie, Milton
Keynes Central, Minffordd, Minster, Mirfield, Mistley, Mitcham Eastfields, Mitcham Junction,
Mobberley, Monifieth, Monks Risborough, Montpelier, Montrose, Moorfields, Moorgate, Moorside,
Moorthorpe, Morar, Morchard Road, Morden South, Morecambe, Moreton (Dorset), Moreton
(Merseyside), Moreton-In-Marsh, Morfa Mawddach, Morley, Morpeth, Mortimer, Mortlake, Moses
Gate, Moss Side, Mossley (Greater Manchester), Mossley Hill, Mosspark, Moston, Motherwell,
Motspur Park, Mottingham, Mouldsworth, Moulsecoomb, Mount Florida, Mountain Ash, Mt.
Vernon, Muir Of Ord, Muirend, Musselburgh, Mytholmroyd, Nafferton, Nailsea & Backwell, Nairn,
Nantwich, Narberth, Narborough, Navigation Road, Neath, Needham Market, Neilston, Nelson,
Neston, Netherfield, Nethertown, Netley, New Barnet, New Beckenham, New Brighton, New Clee,
New Cross, New Cross Gate, New Cumnock, New Eltham, New Holland, New Hythe, New Lane, New
Malden, New Mills Central, New Mills Newtown, New Milton, New Pudsey, New Southgate, Newark
Castle, Newark North Gate, Newbridge, Newbury, Newbury Racecourse, Newcastle, Newcraighall,
Newhaven Harbour, Newhaven Town, Newington, Newmarket, Newport (Essex), Newport (Gwent),
Newquay, Newstead, Newton, Newton Abbot, Newton Aycliffe, Newton For Hyde, Newton St.Cyres,
Newton-Le-Willows, Newton-On-Ayr, Newtonmore, Newtown, Ninian Park, Nitshill, Norbiton,
Norbury, Normans Bay, Normanton, North Berwick, North Camp, North Dulwich, North Llanrwst,
North Queensferry, North Road, North Sheen, North Walsham, North Wembley, Northallerton,
Northampton, Northfield, Northfleet, Northolt Park, Northumberland Park, Northwich, Norwich,
Norwood Junction, Nottingham, Nuneaton, Nunhead, Nunthorpe, Nutbourne, Nutfield, Oakengates,
Oakham, Oakleigh Park, Oban, Ockendon, Ockley, Okehampton, Old Hill, Old Roan, Old Street,
Oldfield Park, Olton, Ore, Ormskirk, Orpington, Orrell, Orrell Park, Otford, Oulton Broad North,
Oulton Broad South, Outwood, Overpool, Overton, Oxenholme Lake District, Oxford, Oxshott, Oxted,
Paddington, Paddock Wood, Padgate, Paignton, Paisley Canal, Paisley Gilmour Street, Paisley
St.James, Palmers Green, Pangbourne, Pannal, Pantyffynnon, Par, Parbold, Park Street, Parkstone,
Parson Street, Partick, Parton, Patchway, Patricroft, Patterton, Peartree, Peckham Rye, Pegswood,
Pemberton, Pembrey & Burry Port, Pembroke, Pembroke Dock, Pen-Y-Bont, Penally, Penarth,
Pencoed, Pengam, Penge East, Penge West, Penhelig, Penistone, Penkridge, Penmaenmawr,
Penmere, Penrhiwceiber, Penrhyndeudraeth, Penrith, Penryn, Pensarn, Penshurst, Pentre-Bach,
Penyffordd, Penzance, Perranwell, Perry Barr, Pershore, Perth, Peterborough, Petersfield, Petts
Wood, Pevensey & Westham, Pevensey Bay, Pewsey, Pilning, Pinhoe, Pitlochry, Pitsea, Pleasington,
Plockton, Pluckley, Plumley, Plumpton, Plumstead, Plymouth, Pokesdown, Polegate, Polesworth,
Pollokshaws East, Pollokshaws West, Pollokshields East, Pollokshields West, Polmont, Polsloe Bridge,
Ponders End, Pont-y-Pant, Pontarddulais, Pontefract Baghill, Pontefract Monkhill, Pontefract
Tanshelf, Pontlottyn, Pontyclun, Pontypool and New Inn, Pontypridd, Poole, Poppleton, Port
Glasgow, Port Sunlight, Port Talbot Parkway, Portchester, Porth, Porthmadog, Portlethen, Portslade,
Portsmouth & Southsea, Portsmouth Arms, Portsmouth Harbour, Possilpark & Parkhouse, Potters
Bar, Poulton-Le-Fylde, Poynton, Prees, Prescot, Prestatyn, Prestbury, Preston, Preston Park,
Prestonpans, Prestwick, Prestwick Internat'nl Airport, Priesthill & Darnley, Princes Risborough,
Prittlewell, Prudhoe, Pulborough, Purfleet, Purley, Purley Oaks, Putney, Pwllheli, Pyle, Quaker's Yard,
Queen's Park (Glasgow), Queen's Park (Gt London), Queen's Road Peckham, Queenborough,
Queenstown Road (Battersea), Quintrel Downs, Radcliffe (Nottinghamshire), Radlett, Radley, Radyr,
Rainford, Rainham (Essex), Rainham (Kent), Rainhill, Ramsgate, Ramsgreave & Wilpshire, Rannoch
For Kinloch Rannoch, Rauceby, Ravenglass, Ravensbourne, Ravensthorpe, Rawcliffe, Rayleigh,
Raynes Park, Reading, Reading West, Rectory Road, Redbridge, Redcar Central, Redcar East, Reddish
North, Reddish South, Redditch, Redhill, Redland, Redruth, Reedham (Greater London), Reedham
(Norfolk), Reigate, Renton, Retford, Rhiwbina, Rhoose (Cardiff Int Airpt), Rhosneigr, Rhyl, Rhymney,
Ribblehead, Rice Lane, Richmond, Rickmansworth, Riddlesdown, Ridgmont, Riding Mill, Risca and
Pontymister, Rishton, Robertsbridge, Roby, Rochdale, Roche, Rochester, Rochford, Rock Ferry,
Rogart, Rogerstone, Rolleston, Roman Bridge, Romford, Romiley, Romsey, Roose, Rose Grove, Rose
Hill(Marple), Rosyth, Rotherham Central, Rotherhithe, Roughton Road, Rowland's Castle, Rowley
Regis, Roy Bridge, Roydon, Royston, Ruabon, Rufford, Rugby, Rugeley Town, Rugeley Trent Valley,
Runcorn, Runcorn East, Ruskington, Ruswarp, Rutherglen, Ryde Esplanade, Ryde Pier Head, Ryde
St.John's Road, Ryder Brow, Rye, Rye House, Salford, Salford Crescent, Salfords, Salhouse, Salisbury,
Saltaire, Saltash, Saltburn, Saltcoats, Saltmarshe, Salwick, Sampford Courtenay, Sandal And Agbrigg,
Sandbach, Sanderstead, Sandhills, Sandhurst, Sandling, Sandown, Sandplace, Sandwell & Dudley,
Sandwich, Sandy, Sankey For Penketh, Sanquhar, Sarn, Saundersfoot, Saunderton, Sawbridgeworth,
Saxilby, Saxmundham, Scarborough, Scotscalder, Scotstounhill, Scunthorpe, Sea Mills, Seaford,
Seaforth & Litherland, Seaham, Seamer, Seascale, Seaton Carew, Seer Green, Selby, Selhurst,
Sellafield, Selling, Selly Oak, Settle, Seven Kings, Seven Sisters, Sevenoaks, Severn Beach, Severn
Tunnel Junction, Shadwell, Shalford, Shanklin, Shawford, Shawlands, Sheerness-On-Sea, Sheffield,
Shelford, Shenfield, Shenstone, Shepherd's Well, Shepherds Bush, Shepley, Shepperton, Shepreth,
Sherborne, Sherburn-In-Elmet, Sheringham, Shettleston, Shieldmuir, Shifnal, Shildon, Shiplake,
Shipley, Shippea Hill, Shipton, Shirebrook (Derbys), Shirehampton, Shireoaks, Shirley, Shoeburyness,
Sholing, Shoreditch High Street, Shoreham (Kent), Shoreham-By-Sea, Shortlands, Shotton, Shotts,
Shrewsbury, Sidcup, Sileby, Silecroft, Silkstone Common, Silver Street, Silverdale, Singer,
Sittingbourne, Skegness, Skewen, Skipton, Slade Green, Slaithwaite, Slateford, Sleaford, Sleights,
Slough, Small Heath, Smallbrook Junction, Smethwick Galton Bridge, Smethwick Rolfe Street, Smithy
Bridge, Snaith, Snodland, Snowdown, Sole Street, Solihull, Somerleyton, South Acton, South Bank,
South Bermondsey, South Croydon, South Elmsall, South Greenford, South Gyle, South Hampstead,
South Kenton, South Merton, South Milford, South Ruislip, South Tottenham, South Wigston,
Southall, Southampton Airport (Parkway), Southampton Central, Southbourne, Southbury,
Southease, Southend Airport, Southend Central, Southend East, Southend Victoria, Southminster,
Southport, Southwick, Sowerby Bridge, Spalding, Spean Bridge, Spital, Spondon, Spooner Row,
Spring Road, Springburn, Springfield, Squires Gate, St.Albans Abbey, St.Albans City, St.Andrew's
Road, St.Annes-On-The-Sea, St.Austell, St.Bees, St.Budeaux Ferry Road, St.Budeaux Victoria Road,
St.Columb Road, St.Denys, St.Erth, St.Germans, St.Helens Central, St.Helens Junction, St.Helier,
St.Ives, St.James' Park, St.James' Street, St.John's, St.Keyne, St.Leonards Warrior Square,
St.Margaret's (Greater London), St.Margaret's (Hertfordshire), St.Mary Cray, St.Michaels, St.Neots,
St.Pancras, Stafford, Staines, Stallingborough, Stalybridge, Stamford, Stamford Hill, Stanford-LeHope,
Stanlow & Thornton, Stansted Airport, Stansted Mountfitchet, Staplehurst, Stapleton Road,
Starbeck, Starcross, Staveley (Cumbria), Stechford, Steeton & Silsden, Stepps, Stevenage,
Stevenston, Stewartby, Stewarton, Stirling, Stockport, Stocksfield, Stocksmoor, Stockton, Stoke
Mandeville, Stoke Newington, Stoke-On-Trent, Stone, Stone Crossing, Stonebridge Park, Stonegate,
Stonehaven, Stonehouse, Stoneleigh, Stourbridge Junction, Stourbridge Town, Stowmarket,
Stranraer, Stratford, Stratford International, Stratford-Upon-Avon, Strathcarron, Strawberry Hill,
Streatham, Streatham Common, Streatham Hill, Streethouse, Strines, Stromeferry, Strood, Stroud,
Sturry, Styal, Sudbury, Sudbury & Harrow Road, Sudbury Hill Harrow, Sugar Loaf, Summerston,
Sunbury, Sunderland, Sundridge Park, Sunningdale, Sunnymeads, Surbiton, Surrey Quays, Sutton
(Surrey), Sutton Coldfield, Sutton Common, Sutton Parkway, Swale, Swanley, Swanscombe, Swansea,
Swanwick, Sway, Swaythling, Swinderby, Swindon, Swineshead, Swinton (Greater Manchester),
Swinton (South Yorkshire), Sydenham, Sydenham Hill, Syon Lane, Syston, Tackley, Tadworth, Taffs
Well, Tain, Tal-y-Cafn, Talsarnau, Talybont, Tame Bridge Parkway, Tamworth Low Level, Taplow,
Tattenham Corner, Taunton, Taynuilt, Teddington, Tees-Side Airport, Teignmouth, Telford Central,
Templecombe, Tenby, Teynham, Thames Ditton, Thatcham, Thatto Heath, The Hawthorns, The
Lakes, Theale, Theobalds Grove, Thetford, Thirsk, Thornaby, Thorne North, Thorne South, Thornford,
Thornliebank, Thornton Abbey, Thornton Heath, Thorntonhall, Thorpe Bay, Thorpe Culvert, Thorpele-Soken,
Three Bridges, Three Oaks, Thurgarton, Thurnscoe, Thurso, Thurston, Tilbury Town, Tile
Hill, Tilehurst, Tipton, Tir-Phil, Tisbury, Tiverton Parkway, Todmorden, Tolworth, Ton Pentre,
Tonbridge, Tondu, Tonfanau, Tonypandy, Tooting, Topsham, Torquay, Torre, Totnes, Tottenham
Hale, Totton, Town Green, Trafford Park, Trefforest, Trefforest Estate, Trehafod, Treherbert,
Treorchy, Trimley, Tring, Troed-Y-Rhiw, Troon, Trowbridge, Truro, Tulloch, Tulse Hill, Tunbridge
Wells, Turkey Street, Tutbury & Hatton, Twickenham, Twyford, Ty Croes, Ty Glas, Tygwyn, Tyndrum
Lower, Tyseley, Tywyn, Uckfield, Uddingston, Ulceby, Ulleskelf, Ulverston, Umberleigh, University,
Uphall, Upholland, Upminster, Upper Halliford, Upper Holloway, Upper Tyndrum, Upper
Warlingham, Upton, Upwey, Urmston, Uttoxeter, Valley, Vauxhall, Victoria, Virginia Water, Waddon,
Wadhurst, Wainfleet, Wakefield Kirkgate, Wakefield Westgate, Walkden, Wallasey Grove Road,
Wallasey Village, Wallington, Wallyford, Walmer, Walsall, Walsden, Waltham Cross, Walthamstow
Central, Walthamstow Queens Road, Walton (Merseyside), Walton-On-Naze, Walton-On-Thames,
Wanborough, Wandsworth Common, Wandsworth Road, Wandsworth Town, Wanstead Park,
Wapping, Warblington, Ware, Wareham, Wargrave, Warminster, Warnham, Warrington Bank Quay,
Warrington Central, Warwick, Warwick Parkway, Water Orton, Waterbeach, Wateringbury,
Waterloo, Waterloo (East), Waterloo (Merseyside), Watford High Street, Watford Junction, Watford
North, Watlington, Watton-At-Stone, Waun-gron Park, Wavertree Technology Park, Weeley,
Weeton, Welham Green, Welling, Wellingborough, Wellington, Welshpool, Welwyn Garden City,
Welwyn North, Wem, Wembley Central, Wembley Stadium, Wemyss Bay, Wendover, Wennington,
West Allerton, West Brompton, West Byfleet, West Calder, West Croydon, West Drayton, West
Dulwich, West Ealing, West Ham, West Hampstead, West Hampstead Thameslink, West Horndon,
West Kilbride, West Kirby, West Malling, West Norwood, West Ruislip, West Runton, West St
Leonards, West Sutton, West Wickham, West Worthing, Westbury, Westcliff, Westcombe Park,
Westenhanger, Wester Hailes, Westerfield, Westerton, Westgate-On-Sea, Westhoughton, Weston
Milton, Weston-Super-Mare, Wetheral, Weybridge, Weymouth, Whaley Bridge, Whalley,
Whatstandwell, Whifflet, Whimple, Whinhill, Whiston, Whitby, Whitchurch (Hampshire), Whitchurch
(Salop), Whitchurch (South Glamorgan), White Hart Lane, White Notley, Whitechapel, Whitecraigs,
Whitehaven, Whitland, Whitley Bridge, Whitlock's End, Whitstable, Whittlesea, Whittlesford,
Whitton, Whitwell (Derbys), Whyteleafe, Whyteleafe South, Wick, Wickford, Wickham Market,
Widdrington, Widnes, Widney Manor, Wigan North Western, Wigan Wallgate, Wigton, Wildmill,
Willesden Junction, Williamwood, Willington, Wilmcote, Wilmslow, Wilnecote, Wimbledon,
Wimbledon Chase, Winchelsea, Winchester, Winchfield, Winchmore Hill, Windermere, Windsor &
Eton Central, Windsor & Eton Riverside, Winnersh, Winnersh Triangle, Winsford, Wishaw, Witham,
Witley, Witton, Wivelsfield, Wivenhoe, Woburn Sands, Woking, Wokingham, Woldingham,
Wolverhampton, Wolverton, Wombwell, Wood End, Wood Street, Woodbridge, Woodgrange Park,
Woodhall, Woodham Ferrers, Woodhouse, Woodlesford, Woodley, Woodmansterne, Woodsmoor,
Wool, Woolston, Woolwich Arsenal, Woolwich Dockyard, Wootton Wawen, Worcester Foregate
Street, Worcester Park, Worcester Shrub Hill, Workington, Worksop, Worle, Worplesdon, Worstead,
Worthing, Wrabness, Wraysbury, Wrenbury, Wressle, Wrexham Central, Wrexham General, Wye,
Wylam, Wylde Green, Wymondham, Wythall, Yalding, Yardley Wood, Yarm, Yate, Yatton, Yeoford,
Yeovil Junction, Yeovil Pen Mill, Yetminster, Ynyswen, Yoker, York, Yorton, Ystrad Mynach, Ystrad
Rhondda".Split();
	}
}