# BenchmarkIt

This is a .NET 6 console app that benchmarks and reports on code. It's great for validating which POC is quicker by comparing 1:n methods.
Check out Program.cs for which benchmark is run. Be sure before you :ship:it!

## Running a benchmark

1. Build the app in Release mode so its fully optimized

`dotnet build -c Release`

2. Run the Release mode app

`dotnet run -c Release`

## Example benchmark

```
// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 2 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// start dotnet restore  /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in C:\Users\adams\OneDrive\Desktop\BenchmarkIt\BenchmarkIt\bin\Release\net6.0\831aa556-1d59-4c9a-95b8-11104d6f4dc4
// command took 2.71s and exited with 0
// start dotnet build -c Release  --no-restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in C:\Users\adams\OneDrive\Desktop\BenchmarkIt\BenchmarkIt\bin\Release\net6.0\831aa556-1d59-4c9a-95b8-11104d6f4dc4
// command took 4.31s and exited with 0
// ***** Done, took 00:00:07 (7.39 sec)   *****
// Found 2 benchmarks:
//   JsonParserBenchmark.Serialize_SystemTextJson: DefaultJob
//   JsonParserBenchmark.Serialize_NewtonsoftJson: DefaultJob

// **************************
// Benchmark: JsonParserBenchmark.Serialize_SystemTextJson: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet "831aa556-1d59-4c9a-95b8-11104d6f4dc4.dll" --benchmarkName "BenchmarkIt.JsonParserBenchmark.Serialize_SystemTextJson" --job "Default" --benchmarkId 0 in C:\Users\adams\OneDrive\Desktop\BenchmarkIt\BenchmarkIt\bin\Release\net6.0\831aa556-1d59-4c9a-95b8-11104d6f4dc4\bin\Release\net6.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT
// GC=Concurrent Workstation
// Job: DefaultJob

OverheadJitting  1: 1 op, 255800.00 ns, 255.8000 us/op
WorkloadJitting  1: 1 op, 46431000.00 ns, 46.4310 ms/op

WorkloadPilot    1: 2 op, 122500.00 ns, 61.2500 us/op
WorkloadPilot    2: 3 op, 30200.00 ns, 10.0667 us/op
WorkloadPilot    3: 4 op, 25000.00 ns, 6.2500 us/op
WorkloadPilot    4: 5 op, 28800.00 ns, 5.7600 us/op
WorkloadPilot    5: 6 op, 57900.00 ns, 9.6500 us/op
WorkloadPilot    6: 7 op, 56200.00 ns, 8.0286 us/op
WorkloadPilot    7: 8 op, 46000.00 ns, 5.7500 us/op
WorkloadPilot    8: 9 op, 43000.00 ns, 4.7778 us/op
WorkloadPilot    9: 10 op, 67600.00 ns, 6.7600 us/op
WorkloadPilot   10: 11 op, 68200.00 ns, 6.2000 us/op
WorkloadPilot   11: 12 op, 69300.00 ns, 5.7750 us/op
WorkloadPilot   12: 13 op, 52400.00 ns, 4.0308 us/op
WorkloadPilot   13: 14 op, 66600.00 ns, 4.7571 us/op
WorkloadPilot   14: 15 op, 62900.00 ns, 4.1933 us/op
WorkloadPilot   15: 16 op, 54300.00 ns, 3.3937 us/op
WorkloadPilot   16: 32 op, 78700.00 ns, 2.4594 us/op
WorkloadPilot   17: 64 op, 134500.00 ns, 2.1016 us/op
WorkloadPilot   18: 128 op, 369900.00 ns, 2.8898 us/op
WorkloadPilot   19: 256 op, 889000.00 ns, 3.4727 us/op
WorkloadPilot   20: 512 op, 1139200.00 ns, 2.2250 us/op
WorkloadPilot   21: 1024 op, 2795500.00 ns, 2.7300 us/op
WorkloadPilot   22: 2048 op, 4386300.00 ns, 2.1417 us/op
WorkloadPilot   23: 4096 op, 14538900.00 ns, 3.5495 us/op
WorkloadPilot   24: 8192 op, 29593800.00 ns, 3.6125 us/op
WorkloadPilot   25: 16384 op, 40361500.00 ns, 2.4635 us/op
WorkloadPilot   26: 32768 op, 74055400.00 ns, 2.2600 us/op
WorkloadPilot   27: 65536 op, 80887900.00 ns, 1.2343 us/op
WorkloadPilot   28: 131072 op, 96124100.00 ns, 733.3687 ns/op
WorkloadPilot   29: 262144 op, 193319000.00 ns, 737.4535 ns/op
WorkloadPilot   30: 524288 op, 390085400.00 ns, 744.0289 ns/op
WorkloadPilot   31: 1048576 op, 863091400.00 ns, 823.1081 ns/op

WorkloadWarmup   1: 1048576 op, 840510200.00 ns, 801.5730 ns/op
WorkloadWarmup   2: 1048576 op, 835145600.00 ns, 796.4569 ns/op
WorkloadWarmup   3: 1048576 op, 765463900.00 ns, 730.0033 ns/op
WorkloadWarmup   4: 1048576 op, 873020000.00 ns, 832.5768 ns/op
WorkloadWarmup   5: 1048576 op, 1169040600.00 ns, 1.1149 us/op
WorkloadWarmup   6: 1048576 op, 1014027300.00 ns, 967.0518 ns/op
WorkloadWarmup   7: 1048576 op, 1745691900.00 ns, 1.6648 us/op
WorkloadWarmup   8: 1048576 op, 2141966200.00 ns, 2.0427 us/op
WorkloadWarmup   9: 1048576 op, 2020502000.00 ns, 1.9269 us/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 2041353400.00 ns, 1.9468 us/op
WorkloadActual   2: 1048576 op, 2232190500.00 ns, 2.1288 us/op
WorkloadActual   3: 1048576 op, 2027615900.00 ns, 1.9337 us/op
WorkloadActual   4: 1048576 op, 2199219800.00 ns, 2.0973 us/op
WorkloadActual   5: 1048576 op, 1959713500.00 ns, 1.8689 us/op
WorkloadActual   6: 1048576 op, 2152051100.00 ns, 2.0524 us/op
WorkloadActual   7: 1048576 op, 1515569500.00 ns, 1.4454 us/op
WorkloadActual   8: 1048576 op, 1402354900.00 ns, 1.3374 us/op
WorkloadActual   9: 1048576 op, 1471029200.00 ns, 1.4029 us/op
WorkloadActual  10: 1048576 op, 2194660000.00 ns, 2.0930 us/op
WorkloadActual  11: 1048576 op, 2254387300.00 ns, 2.1500 us/op
WorkloadActual  12: 1048576 op, 2246867800.00 ns, 2.1428 us/op
WorkloadActual  13: 1048576 op, 1996354000.00 ns, 1.9039 us/op
WorkloadActual  14: 1048576 op, 1805777500.00 ns, 1.7221 us/op
WorkloadActual  15: 1048576 op, 1548468900.00 ns, 1.4767 us/op
WorkloadActual  16: 1048576 op, 1518491900.00 ns, 1.4481 us/op
WorkloadActual  17: 1048576 op, 1393401300.00 ns, 1.3289 us/op
WorkloadActual  18: 1048576 op, 1317834600.00 ns, 1.2568 us/op
WorkloadActual  19: 1048576 op, 1238505800.00 ns, 1.1811 us/op
WorkloadActual  20: 1048576 op, 1120980600.00 ns, 1.0691 us/op
WorkloadActual  21: 1048576 op, 1173536000.00 ns, 1.1192 us/op
WorkloadActual  22: 1048576 op, 1223020900.00 ns, 1.1664 us/op
WorkloadActual  23: 1048576 op, 1113408900.00 ns, 1.0618 us/op
WorkloadActual  24: 1048576 op, 954113700.00 ns, 909.9137 ns/op
WorkloadActual  25: 1048576 op, 1009982800.00 ns, 963.1947 ns/op
WorkloadActual  26: 1048576 op, 993328100.00 ns, 947.3115 ns/op
WorkloadActual  27: 1048576 op, 1099314900.00 ns, 1.0484 us/op
WorkloadActual  28: 1048576 op, 1063482200.00 ns, 1.0142 us/op
WorkloadActual  29: 1048576 op, 1114716500.00 ns, 1.0631 us/op
WorkloadActual  30: 1048576 op, 992533100.00 ns, 946.5533 ns/op
WorkloadActual  31: 1048576 op, 874164700.00 ns, 833.6684 ns/op
WorkloadActual  32: 1048576 op, 892234800.00 ns, 850.9014 ns/op
WorkloadActual  33: 1048576 op, 894138600.00 ns, 852.7170 ns/op
WorkloadActual  34: 1048576 op, 960415900.00 ns, 915.9240 ns/op
WorkloadActual  35: 1048576 op, 863416300.00 ns, 823.4179 ns/op
WorkloadActual  36: 1048576 op, 859102100.00 ns, 819.3036 ns/op
WorkloadActual  37: 1048576 op, 915452600.00 ns, 873.0436 ns/op
WorkloadActual  38: 1048576 op, 842202000.00 ns, 803.1864 ns/op
WorkloadActual  39: 1048576 op, 899695300.00 ns, 858.0163 ns/op
WorkloadActual  40: 1048576 op, 847452300.00 ns, 808.1935 ns/op
WorkloadActual  41: 1048576 op, 834755900.00 ns, 796.0853 ns/op
WorkloadActual  42: 1048576 op, 862405700.00 ns, 822.4542 ns/op
WorkloadActual  43: 1048576 op, 899057500.00 ns, 857.4080 ns/op
WorkloadActual  44: 1048576 op, 841253500.00 ns, 802.2819 ns/op
WorkloadActual  45: 1048576 op, 884632700.00 ns, 843.6515 ns/op
WorkloadActual  46: 1048576 op, 920360800.00 ns, 877.7245 ns/op
WorkloadActual  47: 1048576 op, 942075200.00 ns, 898.4329 ns/op
WorkloadActual  48: 1048576 op, 871037700.00 ns, 830.6863 ns/op
WorkloadActual  49: 1048576 op, 939773500.00 ns, 896.2379 ns/op
WorkloadActual  50: 1048576 op, 937093700.00 ns, 893.6822 ns/op
WorkloadActual  51: 1048576 op, 1035754300.00 ns, 987.7723 ns/op
WorkloadActual  52: 1048576 op, 1722405300.00 ns, 1.6426 us/op
WorkloadActual  53: 1048576 op, 1964407300.00 ns, 1.8734 us/op
WorkloadActual  54: 1048576 op, 1958942700.00 ns, 1.8682 us/op
WorkloadActual  55: 1048576 op, 1620401100.00 ns, 1.5453 us/op
WorkloadActual  56: 1048576 op, 1933640200.00 ns, 1.8441 us/op
WorkloadActual  57: 1048576 op, 1879946800.00 ns, 1.7929 us/op
WorkloadActual  58: 1048576 op, 1867365700.00 ns, 1.7809 us/op
WorkloadActual  59: 1048576 op, 1745610900.00 ns, 1.6647 us/op
WorkloadActual  60: 1048576 op, 2091691200.00 ns, 1.9948 us/op
WorkloadActual  61: 1048576 op, 2128713600.00 ns, 2.0301 us/op
WorkloadActual  62: 1048576 op, 2295987100.00 ns, 2.1896 us/op
WorkloadActual  63: 1048576 op, 2009549200.00 ns, 1.9165 us/op
WorkloadActual  64: 1048576 op, 1674848600.00 ns, 1.5973 us/op
WorkloadActual  65: 1048576 op, 1648177800.00 ns, 1.5718 us/op
WorkloadActual  66: 1048576 op, 1687704100.00 ns, 1.6095 us/op
WorkloadActual  67: 1048576 op, 1479287600.00 ns, 1.4108 us/op
WorkloadActual  68: 1048576 op, 1143988100.00 ns, 1.0910 us/op
WorkloadActual  69: 1048576 op, 1480483500.00 ns, 1.4119 us/op
WorkloadActual  70: 1048576 op, 1764050000.00 ns, 1.6823 us/op
WorkloadActual  71: 1048576 op, 1917030800.00 ns, 1.8282 us/op
WorkloadActual  72: 1048576 op, 1762105300.00 ns, 1.6805 us/op
WorkloadActual  73: 1048576 op, 1849203500.00 ns, 1.7635 us/op
WorkloadActual  74: 1048576 op, 1745254600.00 ns, 1.6644 us/op
WorkloadActual  75: 1048576 op, 1899316000.00 ns, 1.8113 us/op
WorkloadActual  76: 1048576 op, 1785551700.00 ns, 1.7028 us/op
WorkloadActual  77: 1048576 op, 2517873500.00 ns, 2.4012 us/op
WorkloadActual  78: 1048576 op, 2183514400.00 ns, 2.0824 us/op
WorkloadActual  79: 1048576 op, 1751967400.00 ns, 1.6708 us/op
WorkloadActual  80: 1048576 op, 1936014300.00 ns, 1.8463 us/op
WorkloadActual  81: 1048576 op, 1817188400.00 ns, 1.7330 us/op
WorkloadActual  82: 1048576 op, 2439959600.00 ns, 2.3269 us/op
WorkloadActual  83: 1048576 op, 2526218300.00 ns, 2.4092 us/op
WorkloadActual  84: 1048576 op, 1767330000.00 ns, 1.6855 us/op
WorkloadActual  85: 1048576 op, 2045215000.00 ns, 1.9505 us/op
WorkloadActual  86: 1048576 op, 2030014800.00 ns, 1.9360 us/op
WorkloadActual  87: 1048576 op, 1557976600.00 ns, 1.4858 us/op
WorkloadActual  88: 1048576 op, 2350978400.00 ns, 2.2421 us/op
WorkloadActual  89: 1048576 op, 1708787800.00 ns, 1.6296 us/op
WorkloadActual  90: 1048576 op, 1244266300.00 ns, 1.1866 us/op
WorkloadActual  91: 1048576 op, 1459553400.00 ns, 1.3919 us/op
WorkloadActual  92: 1048576 op, 1475975300.00 ns, 1.4076 us/op
WorkloadActual  93: 1048576 op, 1309983200.00 ns, 1.2493 us/op
WorkloadActual  94: 1048576 op, 1863949200.00 ns, 1.7776 us/op
WorkloadActual  95: 1048576 op, 1808207100.00 ns, 1.7244 us/op
WorkloadActual  96: 1048576 op, 1828702300.00 ns, 1.7440 us/op
WorkloadActual  97: 1048576 op, 1888402500.00 ns, 1.8009 us/op
WorkloadActual  98: 1048576 op, 1845438800.00 ns, 1.7599 us/op
WorkloadActual  99: 1048576 op, 1782580600.00 ns, 1.7000 us/op
WorkloadActual  100: 1048576 op, 2060120000.00 ns, 1.9647 us/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 2041353400.00 ns, 1.9468 us/op
WorkloadResult   2: 1048576 op, 2232190500.00 ns, 2.1288 us/op
WorkloadResult   3: 1048576 op, 2027615900.00 ns, 1.9337 us/op
WorkloadResult   4: 1048576 op, 2199219800.00 ns, 2.0973 us/op
WorkloadResult   5: 1048576 op, 1959713500.00 ns, 1.8689 us/op
WorkloadResult   6: 1048576 op, 2152051100.00 ns, 2.0524 us/op
WorkloadResult   7: 1048576 op, 1515569500.00 ns, 1.4454 us/op
WorkloadResult   8: 1048576 op, 1402354900.00 ns, 1.3374 us/op
WorkloadResult   9: 1048576 op, 1471029200.00 ns, 1.4029 us/op
WorkloadResult  10: 1048576 op, 2194660000.00 ns, 2.0930 us/op
WorkloadResult  11: 1048576 op, 2254387300.00 ns, 2.1500 us/op
WorkloadResult  12: 1048576 op, 2246867800.00 ns, 2.1428 us/op
WorkloadResult  13: 1048576 op, 1996354000.00 ns, 1.9039 us/op
WorkloadResult  14: 1048576 op, 1805777500.00 ns, 1.7221 us/op
WorkloadResult  15: 1048576 op, 1548468900.00 ns, 1.4767 us/op
WorkloadResult  16: 1048576 op, 1518491900.00 ns, 1.4481 us/op
WorkloadResult  17: 1048576 op, 1393401300.00 ns, 1.3289 us/op
WorkloadResult  18: 1048576 op, 1317834600.00 ns, 1.2568 us/op
WorkloadResult  19: 1048576 op, 1238505800.00 ns, 1.1811 us/op
WorkloadResult  20: 1048576 op, 1120980600.00 ns, 1.0691 us/op
WorkloadResult  21: 1048576 op, 1173536000.00 ns, 1.1192 us/op
WorkloadResult  22: 1048576 op, 1223020900.00 ns, 1.1664 us/op
WorkloadResult  23: 1048576 op, 1113408900.00 ns, 1.0618 us/op
WorkloadResult  24: 1048576 op, 954113700.00 ns, 909.9137 ns/op
WorkloadResult  25: 1048576 op, 1009982800.00 ns, 963.1947 ns/op
WorkloadResult  26: 1048576 op, 993328100.00 ns, 947.3115 ns/op
WorkloadResult  27: 1048576 op, 1099314900.00 ns, 1.0484 us/op
WorkloadResult  28: 1048576 op, 1063482200.00 ns, 1.0142 us/op
WorkloadResult  29: 1048576 op, 1114716500.00 ns, 1.0631 us/op
WorkloadResult  30: 1048576 op, 992533100.00 ns, 946.5533 ns/op
WorkloadResult  31: 1048576 op, 874164700.00 ns, 833.6684 ns/op
WorkloadResult  32: 1048576 op, 892234800.00 ns, 850.9014 ns/op
WorkloadResult  33: 1048576 op, 894138600.00 ns, 852.7170 ns/op
WorkloadResult  34: 1048576 op, 960415900.00 ns, 915.9240 ns/op
WorkloadResult  35: 1048576 op, 863416300.00 ns, 823.4179 ns/op
WorkloadResult  36: 1048576 op, 859102100.00 ns, 819.3036 ns/op
WorkloadResult  37: 1048576 op, 915452600.00 ns, 873.0436 ns/op
WorkloadResult  38: 1048576 op, 842202000.00 ns, 803.1864 ns/op
WorkloadResult  39: 1048576 op, 899695300.00 ns, 858.0163 ns/op
WorkloadResult  40: 1048576 op, 847452300.00 ns, 808.1935 ns/op
WorkloadResult  41: 1048576 op, 834755900.00 ns, 796.0853 ns/op
WorkloadResult  42: 1048576 op, 862405700.00 ns, 822.4542 ns/op
WorkloadResult  43: 1048576 op, 899057500.00 ns, 857.4080 ns/op
WorkloadResult  44: 1048576 op, 841253500.00 ns, 802.2819 ns/op
WorkloadResult  45: 1048576 op, 884632700.00 ns, 843.6515 ns/op
WorkloadResult  46: 1048576 op, 920360800.00 ns, 877.7245 ns/op
WorkloadResult  47: 1048576 op, 942075200.00 ns, 898.4329 ns/op
WorkloadResult  48: 1048576 op, 871037700.00 ns, 830.6863 ns/op
WorkloadResult  49: 1048576 op, 939773500.00 ns, 896.2379 ns/op
WorkloadResult  50: 1048576 op, 937093700.00 ns, 893.6822 ns/op
WorkloadResult  51: 1048576 op, 1035754300.00 ns, 987.7723 ns/op
WorkloadResult  52: 1048576 op, 1722405300.00 ns, 1.6426 us/op
WorkloadResult  53: 1048576 op, 1964407300.00 ns, 1.8734 us/op
WorkloadResult  54: 1048576 op, 1958942700.00 ns, 1.8682 us/op
WorkloadResult  55: 1048576 op, 1620401100.00 ns, 1.5453 us/op
WorkloadResult  56: 1048576 op, 1933640200.00 ns, 1.8441 us/op
WorkloadResult  57: 1048576 op, 1879946800.00 ns, 1.7929 us/op
WorkloadResult  58: 1048576 op, 1867365700.00 ns, 1.7809 us/op
WorkloadResult  59: 1048576 op, 1745610900.00 ns, 1.6647 us/op
WorkloadResult  60: 1048576 op, 2091691200.00 ns, 1.9948 us/op
WorkloadResult  61: 1048576 op, 2128713600.00 ns, 2.0301 us/op
WorkloadResult  62: 1048576 op, 2295987100.00 ns, 2.1896 us/op
WorkloadResult  63: 1048576 op, 2009549200.00 ns, 1.9165 us/op
WorkloadResult  64: 1048576 op, 1674848600.00 ns, 1.5973 us/op
WorkloadResult  65: 1048576 op, 1648177800.00 ns, 1.5718 us/op
WorkloadResult  66: 1048576 op, 1687704100.00 ns, 1.6095 us/op
WorkloadResult  67: 1048576 op, 1479287600.00 ns, 1.4108 us/op
WorkloadResult  68: 1048576 op, 1143988100.00 ns, 1.0910 us/op
WorkloadResult  69: 1048576 op, 1480483500.00 ns, 1.4119 us/op
WorkloadResult  70: 1048576 op, 1764050000.00 ns, 1.6823 us/op
WorkloadResult  71: 1048576 op, 1917030800.00 ns, 1.8282 us/op
WorkloadResult  72: 1048576 op, 1762105300.00 ns, 1.6805 us/op
WorkloadResult  73: 1048576 op, 1849203500.00 ns, 1.7635 us/op
WorkloadResult  74: 1048576 op, 1745254600.00 ns, 1.6644 us/op
WorkloadResult  75: 1048576 op, 1899316000.00 ns, 1.8113 us/op
WorkloadResult  76: 1048576 op, 1785551700.00 ns, 1.7028 us/op
WorkloadResult  77: 1048576 op, 2517873500.00 ns, 2.4012 us/op
WorkloadResult  78: 1048576 op, 2183514400.00 ns, 2.0824 us/op
WorkloadResult  79: 1048576 op, 1751967400.00 ns, 1.6708 us/op
WorkloadResult  80: 1048576 op, 1936014300.00 ns, 1.8463 us/op
WorkloadResult  81: 1048576 op, 1817188400.00 ns, 1.7330 us/op
WorkloadResult  82: 1048576 op, 2439959600.00 ns, 2.3269 us/op
WorkloadResult  83: 1048576 op, 2526218300.00 ns, 2.4092 us/op
WorkloadResult  84: 1048576 op, 1767330000.00 ns, 1.6855 us/op
WorkloadResult  85: 1048576 op, 2045215000.00 ns, 1.9505 us/op
WorkloadResult  86: 1048576 op, 2030014800.00 ns, 1.9360 us/op
WorkloadResult  87: 1048576 op, 1557976600.00 ns, 1.4858 us/op
WorkloadResult  88: 1048576 op, 2350978400.00 ns, 2.2421 us/op
WorkloadResult  89: 1048576 op, 1708787800.00 ns, 1.6296 us/op
WorkloadResult  90: 1048576 op, 1244266300.00 ns, 1.1866 us/op
WorkloadResult  91: 1048576 op, 1459553400.00 ns, 1.3919 us/op
WorkloadResult  92: 1048576 op, 1475975300.00 ns, 1.4076 us/op
WorkloadResult  93: 1048576 op, 1309983200.00 ns, 1.2493 us/op
WorkloadResult  94: 1048576 op, 1863949200.00 ns, 1.7776 us/op
WorkloadResult  95: 1048576 op, 1808207100.00 ns, 1.7244 us/op
WorkloadResult  96: 1048576 op, 1828702300.00 ns, 1.7440 us/op
WorkloadResult  97: 1048576 op, 1888402500.00 ns, 1.8009 us/op
WorkloadResult  98: 1048576 op, 1845438800.00 ns, 1.7599 us/op
WorkloadResult  99: 1048576 op, 1782580600.00 ns, 1.7000 us/op
WorkloadResult  100: 1048576 op, 2060120000.00 ns, 1.9647 us/op
GC:  160 0 0 503317296 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 15092 has exited with code 0.

Mean = 1.482 us, StdErr = 0.047 us (3.15%), N = 100, StdDev = 0.466 us
Min = 0.796 us, Q1 = 1.008 us, Median = 1.585 us, Q3 = 1.845 us, Max = 2.409 us
IQR = 0.837 us, LowerFence = -0.248 us, UpperFence = 3.100 us
ConfidenceInterval = [1.324 us; 1.641 us] (CI 99.9%), Margin = 0.158 us (10.67% of Mean)
Skewness = -0.03, Kurtosis = 1.74, MValue = 3.21

// **************************
// Benchmark: JsonParserBenchmark.Serialize_NewtonsoftJson: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet "831aa556-1d59-4c9a-95b8-11104d6f4dc4.dll" --benchmarkName "BenchmarkIt.JsonParserBenchmark.Serialize_NewtonsoftJson" --job "Default" --benchmarkId 1 in C:\Users\adams\OneDrive\Desktop\BenchmarkIt\BenchmarkIt\bin\Release\net6.0\831aa556-1d59-4c9a-95b8-11104d6f4dc4\bin\Release\net6.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT
// GC=Concurrent Workstation
// Job: DefaultJob

OverheadJitting  1: 1 op, 225100.00 ns, 225.1000 us/op
WorkloadJitting  1: 1 op, 121317700.00 ns, 121.3177 ms/op

WorkloadPilot    1: 2 op, 71800.00 ns, 35.9000 us/op
WorkloadPilot    2: 3 op, 48400.00 ns, 16.1333 us/op
WorkloadPilot    3: 4 op, 60400.00 ns, 15.1000 us/op
WorkloadPilot    4: 5 op, 63000.00 ns, 12.6000 us/op
WorkloadPilot    5: 6 op, 54400.00 ns, 9.0667 us/op
WorkloadPilot    6: 7 op, 102800.00 ns, 14.6857 us/op
WorkloadPilot    7: 8 op, 62100.00 ns, 7.7625 us/op
WorkloadPilot    8: 9 op, 59700.00 ns, 6.6333 us/op
WorkloadPilot    9: 10 op, 69500.00 ns, 6.9500 us/op
WorkloadPilot   10: 11 op, 55200.00 ns, 5.0182 us/op
WorkloadPilot   11: 12 op, 57800.00 ns, 4.8167 us/op
WorkloadPilot   12: 13 op, 61300.00 ns, 4.7154 us/op
WorkloadPilot   13: 14 op, 60800.00 ns, 4.3429 us/op
WorkloadPilot   14: 15 op, 68500.00 ns, 4.5667 us/op
WorkloadPilot   15: 16 op, 61300.00 ns, 3.8312 us/op
WorkloadPilot   16: 32 op, 108400.00 ns, 3.3875 us/op
WorkloadPilot   17: 64 op, 349400.00 ns, 5.4594 us/op
WorkloadPilot   18: 128 op, 521700.00 ns, 4.0758 us/op
WorkloadPilot   19: 256 op, 892400.00 ns, 3.4859 us/op
WorkloadPilot   20: 512 op, 1728600.00 ns, 3.3762 us/op
WorkloadPilot   21: 1024 op, 3540200.00 ns, 3.4572 us/op
WorkloadPilot   22: 2048 op, 7671400.00 ns, 3.7458 us/op
WorkloadPilot   23: 4096 op, 11833400.00 ns, 2.8890 us/op
WorkloadPilot   24: 8192 op, 22230800.00 ns, 2.7137 us/op
WorkloadPilot   25: 16384 op, 45875200.00 ns, 2.8000 us/op
WorkloadPilot   26: 32768 op, 88976200.00 ns, 2.7153 us/op
WorkloadPilot   27: 65536 op, 143077900.00 ns, 2.1832 us/op
WorkloadPilot   28: 131072 op, 176418100.00 ns, 1.3460 us/op
WorkloadPilot   29: 262144 op, 355282400.00 ns, 1.3553 us/op
WorkloadPilot   30: 524288 op, 718689900.00 ns, 1.3708 us/op

WorkloadWarmup   1: 524288 op, 719860500.00 ns, 1.3730 us/op
WorkloadWarmup   2: 524288 op, 717466100.00 ns, 1.3685 us/op
WorkloadWarmup   3: 524288 op, 827049200.00 ns, 1.5775 us/op
WorkloadWarmup   4: 524288 op, 812860600.00 ns, 1.5504 us/op
WorkloadWarmup   5: 524288 op, 779578200.00 ns, 1.4869 us/op
WorkloadWarmup   6: 524288 op, 786571300.00 ns, 1.5003 us/op
WorkloadWarmup   7: 524288 op, 741679900.00 ns, 1.4146 us/op

// BeforeActualRun
WorkloadActual   1: 524288 op, 854591000.00 ns, 1.6300 us/op
WorkloadActual   2: 524288 op, 1880746600.00 ns, 3.5872 us/op
WorkloadActual   3: 524288 op, 1869955200.00 ns, 3.5667 us/op
WorkloadActual   4: 524288 op, 2081365500.00 ns, 3.9699 us/op
WorkloadActual   5: 524288 op, 1850025900.00 ns, 3.5286 us/op
WorkloadActual   6: 524288 op, 2402463600.00 ns, 4.5823 us/op
WorkloadActual   7: 524288 op, 1791494000.00 ns, 3.4170 us/op
WorkloadActual   8: 524288 op, 2222160700.00 ns, 4.2384 us/op
WorkloadActual   9: 524288 op, 1768097200.00 ns, 3.3724 us/op
WorkloadActual  10: 524288 op, 2185254200.00 ns, 4.1680 us/op
WorkloadActual  11: 524288 op, 1837550100.00 ns, 3.5048 us/op
WorkloadActual  12: 524288 op, 1956142400.00 ns, 3.7310 us/op
WorkloadActual  13: 524288 op, 1933021500.00 ns, 3.6869 us/op
WorkloadActual  14: 524288 op, 2080213600.00 ns, 3.9677 us/op
WorkloadActual  15: 524288 op, 1805016700.00 ns, 3.4428 us/op
WorkloadActual  16: 524288 op, 2340112600.00 ns, 4.4634 us/op
WorkloadActual  17: 524288 op, 2292791700.00 ns, 4.3732 us/op
WorkloadActual  18: 524288 op, 2163220000.00 ns, 4.1260 us/op
WorkloadActual  19: 524288 op, 1620892300.00 ns, 3.0916 us/op
WorkloadActual  20: 524288 op, 2032700700.00 ns, 3.8771 us/op
WorkloadActual  21: 524288 op, 1798913000.00 ns, 3.4312 us/op
WorkloadActual  22: 524288 op, 1776283500.00 ns, 3.3880 us/op
WorkloadActual  23: 524288 op, 1877465200.00 ns, 3.5810 us/op
WorkloadActual  24: 524288 op, 2212530900.00 ns, 4.2201 us/op
WorkloadActual  25: 524288 op, 2106403500.00 ns, 4.0176 us/op
WorkloadActual  26: 524288 op, 2087991900.00 ns, 3.9825 us/op
WorkloadActual  27: 524288 op, 1744583700.00 ns, 3.3275 us/op
WorkloadActual  28: 524288 op, 1821928500.00 ns, 3.4751 us/op
WorkloadActual  29: 524288 op, 1583078700.00 ns, 3.0195 us/op
WorkloadActual  30: 524288 op, 2456433300.00 ns, 4.6853 us/op
WorkloadActual  31: 524288 op, 2085658300.00 ns, 3.9781 us/op
WorkloadActual  32: 524288 op, 2476374400.00 ns, 4.7233 us/op
WorkloadActual  33: 524288 op, 1949796700.00 ns, 3.7189 us/op
WorkloadActual  34: 524288 op, 2750150200.00 ns, 5.2455 us/op
WorkloadActual  35: 524288 op, 1870537900.00 ns, 3.5678 us/op
WorkloadActual  36: 524288 op, 2500965600.00 ns, 4.7702 us/op
WorkloadActual  37: 524288 op, 2372457200.00 ns, 4.5251 us/op
WorkloadActual  38: 524288 op, 2147435100.00 ns, 4.0959 us/op
WorkloadActual  39: 524288 op, 1777990900.00 ns, 3.3912 us/op
WorkloadActual  40: 524288 op, 1989640900.00 ns, 3.7949 us/op
WorkloadActual  41: 524288 op, 2146373800.00 ns, 4.0939 us/op
WorkloadActual  42: 524288 op, 2296621400.00 ns, 4.3805 us/op
WorkloadActual  43: 524288 op, 2816886000.00 ns, 5.3728 us/op
WorkloadActual  44: 524288 op, 2211834500.00 ns, 4.2187 us/op
WorkloadActual  45: 524288 op, 1887315600.00 ns, 3.5998 us/op
WorkloadActual  46: 524288 op, 2138861300.00 ns, 4.0796 us/op
WorkloadActual  47: 524288 op, 2349127300.00 ns, 4.4806 us/op
WorkloadActual  48: 524288 op, 2475655700.00 ns, 4.7219 us/op
WorkloadActual  49: 524288 op, 1584591200.00 ns, 3.0224 us/op
WorkloadActual  50: 524288 op, 2095833300.00 ns, 3.9975 us/op
WorkloadActual  51: 524288 op, 2461828800.00 ns, 4.6956 us/op
WorkloadActual  52: 524288 op, 2820945100.00 ns, 5.3805 us/op
WorkloadActual  53: 524288 op, 2323771000.00 ns, 4.4322 us/op
WorkloadActual  54: 524288 op, 2870774000.00 ns, 5.4756 us/op
WorkloadActual  55: 524288 op, 2389132500.00 ns, 4.5569 us/op
WorkloadActual  56: 524288 op, 2431233900.00 ns, 4.6372 us/op
WorkloadActual  57: 524288 op, 2453746400.00 ns, 4.6801 us/op
WorkloadActual  58: 524288 op, 2247860900.00 ns, 4.2875 us/op
WorkloadActual  59: 524288 op, 1917055100.00 ns, 3.6565 us/op
WorkloadActual  60: 524288 op, 2901092600.00 ns, 5.5334 us/op
WorkloadActual  61: 524288 op, 2312328700.00 ns, 4.4104 us/op
WorkloadActual  62: 524288 op, 1913936900.00 ns, 3.6505 us/op
WorkloadActual  63: 524288 op, 1969561700.00 ns, 3.7566 us/op
WorkloadActual  64: 524288 op, 1939135600.00 ns, 3.6986 us/op
WorkloadActual  65: 524288 op, 2741088600.00 ns, 5.2282 us/op
WorkloadActual  66: 524288 op, 3069295100.00 ns, 5.8542 us/op
WorkloadActual  67: 524288 op, 2629145500.00 ns, 5.0147 us/op
WorkloadActual  68: 524288 op, 2435488200.00 ns, 4.6453 us/op
WorkloadActual  69: 524288 op, 2627043200.00 ns, 5.0107 us/op
WorkloadActual  70: 524288 op, 2043926600.00 ns, 3.8985 us/op
WorkloadActual  71: 524288 op, 1742600700.00 ns, 3.3237 us/op
WorkloadActual  72: 524288 op, 2185522000.00 ns, 4.1686 us/op
WorkloadActual  73: 524288 op, 2018500100.00 ns, 3.8500 us/op
WorkloadActual  74: 524288 op, 1771722100.00 ns, 3.3793 us/op
WorkloadActual  75: 524288 op, 2343460200.00 ns, 4.4698 us/op
WorkloadActual  76: 524288 op, 2565372700.00 ns, 4.8931 us/op
WorkloadActual  77: 524288 op, 2565865900.00 ns, 4.8940 us/op
WorkloadActual  78: 524288 op, 1748856400.00 ns, 3.3357 us/op
WorkloadActual  79: 524288 op, 1959147900.00 ns, 3.7368 us/op
WorkloadActual  80: 524288 op, 2332125300.00 ns, 4.4482 us/op
WorkloadActual  81: 524288 op, 1884682900.00 ns, 3.5947 us/op
WorkloadActual  82: 524288 op, 1364712200.00 ns, 2.6030 us/op
WorkloadActual  83: 524288 op, 1497031800.00 ns, 2.8554 us/op
WorkloadActual  84: 524288 op, 2068410900.00 ns, 3.9452 us/op
WorkloadActual  85: 524288 op, 2670431700.00 ns, 5.0934 us/op
WorkloadActual  86: 524288 op, 2113152700.00 ns, 4.0305 us/op
WorkloadActual  87: 524288 op, 2699721100.00 ns, 5.1493 us/op
WorkloadActual  88: 524288 op, 1991592100.00 ns, 3.7987 us/op
WorkloadActual  89: 524288 op, 1451281600.00 ns, 2.7681 us/op
WorkloadActual  90: 524288 op, 1606943100.00 ns, 3.0650 us/op
WorkloadActual  91: 524288 op, 948485300.00 ns, 1.8091 us/op
WorkloadActual  92: 524288 op, 2469559600.00 ns, 4.7103 us/op
WorkloadActual  93: 524288 op, 1832154400.00 ns, 3.4946 us/op
WorkloadActual  94: 524288 op, 1301634600.00 ns, 2.4827 us/op
WorkloadActual  95: 524288 op, 1521866000.00 ns, 2.9027 us/op
WorkloadActual  96: 524288 op, 2866459600.00 ns, 5.4673 us/op
WorkloadActual  97: 524288 op, 1375904800.00 ns, 2.6243 us/op
WorkloadActual  98: 524288 op, 1383488900.00 ns, 2.6388 us/op
WorkloadActual  99: 524288 op, 1456276200.00 ns, 2.7776 us/op
WorkloadActual  100: 524288 op, 1193664300.00 ns, 2.2767 us/op

// AfterActualRun
WorkloadResult   1: 524288 op, 854591000.00 ns, 1.6300 us/op
WorkloadResult   2: 524288 op, 1880746600.00 ns, 3.5872 us/op
WorkloadResult   3: 524288 op, 1869955200.00 ns, 3.5667 us/op
WorkloadResult   4: 524288 op, 2081365500.00 ns, 3.9699 us/op
WorkloadResult   5: 524288 op, 1850025900.00 ns, 3.5286 us/op
WorkloadResult   6: 524288 op, 2402463600.00 ns, 4.5823 us/op
WorkloadResult   7: 524288 op, 1791494000.00 ns, 3.4170 us/op
WorkloadResult   8: 524288 op, 2222160700.00 ns, 4.2384 us/op
WorkloadResult   9: 524288 op, 1768097200.00 ns, 3.3724 us/op
WorkloadResult  10: 524288 op, 2185254200.00 ns, 4.1680 us/op
WorkloadResult  11: 524288 op, 1837550100.00 ns, 3.5048 us/op
WorkloadResult  12: 524288 op, 1956142400.00 ns, 3.7310 us/op
WorkloadResult  13: 524288 op, 1933021500.00 ns, 3.6869 us/op
WorkloadResult  14: 524288 op, 2080213600.00 ns, 3.9677 us/op
WorkloadResult  15: 524288 op, 1805016700.00 ns, 3.4428 us/op
WorkloadResult  16: 524288 op, 2340112600.00 ns, 4.4634 us/op
WorkloadResult  17: 524288 op, 2292791700.00 ns, 4.3732 us/op
WorkloadResult  18: 524288 op, 2163220000.00 ns, 4.1260 us/op
WorkloadResult  19: 524288 op, 1620892300.00 ns, 3.0916 us/op
WorkloadResult  20: 524288 op, 2032700700.00 ns, 3.8771 us/op
WorkloadResult  21: 524288 op, 1798913000.00 ns, 3.4312 us/op
WorkloadResult  22: 524288 op, 1776283500.00 ns, 3.3880 us/op
WorkloadResult  23: 524288 op, 1877465200.00 ns, 3.5810 us/op
WorkloadResult  24: 524288 op, 2212530900.00 ns, 4.2201 us/op
WorkloadResult  25: 524288 op, 2106403500.00 ns, 4.0176 us/op
WorkloadResult  26: 524288 op, 2087991900.00 ns, 3.9825 us/op
WorkloadResult  27: 524288 op, 1744583700.00 ns, 3.3275 us/op
WorkloadResult  28: 524288 op, 1821928500.00 ns, 3.4751 us/op
WorkloadResult  29: 524288 op, 1583078700.00 ns, 3.0195 us/op
WorkloadResult  30: 524288 op, 2456433300.00 ns, 4.6853 us/op
WorkloadResult  31: 524288 op, 2085658300.00 ns, 3.9781 us/op
WorkloadResult  32: 524288 op, 2476374400.00 ns, 4.7233 us/op
WorkloadResult  33: 524288 op, 1949796700.00 ns, 3.7189 us/op
WorkloadResult  34: 524288 op, 2750150200.00 ns, 5.2455 us/op
WorkloadResult  35: 524288 op, 1870537900.00 ns, 3.5678 us/op
WorkloadResult  36: 524288 op, 2500965600.00 ns, 4.7702 us/op
WorkloadResult  37: 524288 op, 2372457200.00 ns, 4.5251 us/op
WorkloadResult  38: 524288 op, 2147435100.00 ns, 4.0959 us/op
WorkloadResult  39: 524288 op, 1777990900.00 ns, 3.3912 us/op
WorkloadResult  40: 524288 op, 1989640900.00 ns, 3.7949 us/op
WorkloadResult  41: 524288 op, 2146373800.00 ns, 4.0939 us/op
WorkloadResult  42: 524288 op, 2296621400.00 ns, 4.3805 us/op
WorkloadResult  43: 524288 op, 2816886000.00 ns, 5.3728 us/op
WorkloadResult  44: 524288 op, 2211834500.00 ns, 4.2187 us/op
WorkloadResult  45: 524288 op, 1887315600.00 ns, 3.5998 us/op
WorkloadResult  46: 524288 op, 2138861300.00 ns, 4.0796 us/op
WorkloadResult  47: 524288 op, 2349127300.00 ns, 4.4806 us/op
WorkloadResult  48: 524288 op, 2475655700.00 ns, 4.7219 us/op
WorkloadResult  49: 524288 op, 1584591200.00 ns, 3.0224 us/op
WorkloadResult  50: 524288 op, 2095833300.00 ns, 3.9975 us/op
WorkloadResult  51: 524288 op, 2461828800.00 ns, 4.6956 us/op
WorkloadResult  52: 524288 op, 2820945100.00 ns, 5.3805 us/op
WorkloadResult  53: 524288 op, 2323771000.00 ns, 4.4322 us/op
WorkloadResult  54: 524288 op, 2870774000.00 ns, 5.4756 us/op
WorkloadResult  55: 524288 op, 2389132500.00 ns, 4.5569 us/op
WorkloadResult  56: 524288 op, 2431233900.00 ns, 4.6372 us/op
WorkloadResult  57: 524288 op, 2453746400.00 ns, 4.6801 us/op
WorkloadResult  58: 524288 op, 2247860900.00 ns, 4.2875 us/op
WorkloadResult  59: 524288 op, 1917055100.00 ns, 3.6565 us/op
WorkloadResult  60: 524288 op, 2901092600.00 ns, 5.5334 us/op
WorkloadResult  61: 524288 op, 2312328700.00 ns, 4.4104 us/op
WorkloadResult  62: 524288 op, 1913936900.00 ns, 3.6505 us/op
WorkloadResult  63: 524288 op, 1969561700.00 ns, 3.7566 us/op
WorkloadResult  64: 524288 op, 1939135600.00 ns, 3.6986 us/op
WorkloadResult  65: 524288 op, 2741088600.00 ns, 5.2282 us/op
WorkloadResult  66: 524288 op, 3069295100.00 ns, 5.8542 us/op
WorkloadResult  67: 524288 op, 2629145500.00 ns, 5.0147 us/op
WorkloadResult  68: 524288 op, 2435488200.00 ns, 4.6453 us/op
WorkloadResult  69: 524288 op, 2627043200.00 ns, 5.0107 us/op
WorkloadResult  70: 524288 op, 2043926600.00 ns, 3.8985 us/op
WorkloadResult  71: 524288 op, 1742600700.00 ns, 3.3237 us/op
WorkloadResult  72: 524288 op, 2185522000.00 ns, 4.1686 us/op
WorkloadResult  73: 524288 op, 2018500100.00 ns, 3.8500 us/op
WorkloadResult  74: 524288 op, 1771722100.00 ns, 3.3793 us/op
WorkloadResult  75: 524288 op, 2343460200.00 ns, 4.4698 us/op
WorkloadResult  76: 524288 op, 2565372700.00 ns, 4.8931 us/op
WorkloadResult  77: 524288 op, 2565865900.00 ns, 4.8940 us/op
WorkloadResult  78: 524288 op, 1748856400.00 ns, 3.3357 us/op
WorkloadResult  79: 524288 op, 1959147900.00 ns, 3.7368 us/op
WorkloadResult  80: 524288 op, 2332125300.00 ns, 4.4482 us/op
WorkloadResult  81: 524288 op, 1884682900.00 ns, 3.5947 us/op
WorkloadResult  82: 524288 op, 1364712200.00 ns, 2.6030 us/op
WorkloadResult  83: 524288 op, 1497031800.00 ns, 2.8554 us/op
WorkloadResult  84: 524288 op, 2068410900.00 ns, 3.9452 us/op
WorkloadResult  85: 524288 op, 2670431700.00 ns, 5.0934 us/op
WorkloadResult  86: 524288 op, 2113152700.00 ns, 4.0305 us/op
WorkloadResult  87: 524288 op, 2699721100.00 ns, 5.1493 us/op
WorkloadResult  88: 524288 op, 1991592100.00 ns, 3.7987 us/op
WorkloadResult  89: 524288 op, 1451281600.00 ns, 2.7681 us/op
WorkloadResult  90: 524288 op, 1606943100.00 ns, 3.0650 us/op
WorkloadResult  91: 524288 op, 948485300.00 ns, 1.8091 us/op
WorkloadResult  92: 524288 op, 2469559600.00 ns, 4.7103 us/op
WorkloadResult  93: 524288 op, 1832154400.00 ns, 3.4946 us/op
WorkloadResult  94: 524288 op, 1301634600.00 ns, 2.4827 us/op
WorkloadResult  95: 524288 op, 1521866000.00 ns, 2.9027 us/op
WorkloadResult  96: 524288 op, 2866459600.00 ns, 5.4673 us/op
WorkloadResult  97: 524288 op, 1375904800.00 ns, 2.6243 us/op
WorkloadResult  98: 524288 op, 1383488900.00 ns, 2.6388 us/op
WorkloadResult  99: 524288 op, 1456276200.00 ns, 2.7776 us/op
WorkloadResult  100: 524288 op, 1193664300.00 ns, 2.2767 us/op
GC:  282 0 0 884998528 524288
Threading:  0 0 524288

// AfterAll
// Benchmark Process 19924 has exited with code 0.

Mean = 3.963 us, StdErr = 0.083 us (2.08%), N = 100, StdDev = 0.825 us
Min = 1.630 us, Q1 = 3.467 us, Median = 3.969 us, Q3 = 4.533 us, Max = 5.854 us
IQR = 1.066 us, LowerFence = 1.868 us, UpperFence = 6.132 us
ConfidenceInterval = [3.683 us; 4.243 us] (CI 99.9%), Margin = 0.280 us (7.06% of Mean)
Skewness = -0.18, Kurtosis = 2.98, MValue = 2.57

// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\BenchmarkIt.JsonParserBenchmark-report.csv
  BenchmarkDotNet.Artifacts\results\BenchmarkIt.JsonParserBenchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\BenchmarkIt.JsonParserBenchmark-report.html

// * Detailed results *
JsonParserBenchmark.Serialize_SystemTextJson: DefaultJob
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT; GC = Concurrent Workstation
Mean = 1.482 us, StdErr = 0.047 us (3.15%), N = 100, StdDev = 0.466 us
Min = 0.796 us, Q1 = 1.008 us, Median = 1.585 us, Q3 = 1.845 us, Max = 2.409 us
IQR = 0.837 us, LowerFence = -0.248 us, UpperFence = 3.100 us
ConfidenceInterval = [1.324 us; 1.641 us] (CI 99.9%), Margin = 0.158 us (10.67% of Mean)
Skewness = -0.03, Kurtosis = 1.74, MValue = 3.21
-------------------- Histogram --------------------
[0.664 us ; 0.801 us) | @
[0.801 us ; 1.065 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.065 us ; 1.369 us) | @@@@@@@@@@
[1.369 us ; 1.620 us) | @@@@@@@@@@@@@
[1.620 us ; 1.883 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.883 us ; 2.159 us) | @@@@@@@@@@@@@@@@
[2.159 us ; 2.431 us) | @@@@@
---------------------------------------------------

JsonParserBenchmark.Serialize_NewtonsoftJson: DefaultJob
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT; GC = Concurrent Workstation
Mean = 3.963 us, StdErr = 0.083 us (2.08%), N = 100, StdDev = 0.825 us
Min = 1.630 us, Q1 = 3.467 us, Median = 3.969 us, Q3 = 4.533 us, Max = 5.854 us
IQR = 1.066 us, LowerFence = 1.868 us, UpperFence = 6.132 us
ConfidenceInterval = [3.683 us; 4.243 us] (CI 99.9%), Margin = 0.280 us (7.06% of Mean)
Skewness = -0.18, Kurtosis = 2.98, MValue = 2.57
-------------------- Histogram --------------------
[1.486 us ; 1.953 us) | @@
[1.953 us ; 2.146 us) |
[2.146 us ; 2.601 us) | @@
[2.601 us ; 3.067 us) | @@@@@@@@@@
[3.067 us ; 3.307 us) | @
[3.307 us ; 3.774 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[3.774 us ; 4.250 us) | @@@@@@@@@@@@@@@@@@@@@@
[4.250 us ; 4.805 us) | @@@@@@@@@@@@@@@@@@@@@
[4.805 us ; 5.010 us) | @@
[5.010 us ; 5.476 us) | @@@@@@@@@@
[5.476 us ; 5.927 us) | @@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


|                   Method |     Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|------------------------- |---------:|----------:|----------:|-----:|-------:|----------:|
| Serialize_SystemTextJson | 1.482 us | 0.1582 us | 0.4663 us |    1 | 0.1526 |     480 B |
| Serialize_NewtonsoftJson | 3.963 us | 0.2799 us | 0.8252 us |    2 | 0.5379 |   1,688 B |

// * Warnings *
MultimodalDistribution
  JsonParserBenchmark.Serialize_SystemTextJson: Default -> It seems that the distribution is bimodal (mValue = 3.21)

// * Hints *
Outliers
  JsonParserBenchmark.Serialize_NewtonsoftJson: Default -> 2 outliers were detected (1.63 us, 1.81 us)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Rank      : Relative position of current benchmark mean among all benchmarks (Arabic style)
  Gen 0     : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 us      : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
// ** Remained 0 benchmark(s) to run **
Run time: 00:06:29 (389.01 sec), executed benchmarks: 2

Global total time: 00:06:36 (396.41 sec), executed benchmarks: 2
// * Artifacts cleanup *
```
