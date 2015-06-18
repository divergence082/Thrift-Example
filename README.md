# Thrift-Example
Simple thrift service creation example

1. Install thrift:
  1.1. Install dependencies:
  ```
  sudo apt-get install libboost-dev libboost-test-dev libboost-program-options-dev    
  libboost-chrono-dev libboost-thread-dev libboost-system-dev libboost-filesystem-dev    
  libevent-dev automake libtool flex bison pkg-config g++ libssl-dev
  ```

  1.2. Clone git repo:
  ```
  git clone https://git-wip-us.apache.org/repos/asf/thrift.git thrift
  ```

  1.3. Build:
  ```
  cd thrift && ./bootstrap.sh && ./configure && make -j4
  ```

  1.4. Install:
  ```
  sudo make install
  ```

2. Create idl files:        
  - [IDL](http://thrift.apache.org/docs/idl)
  - [Thrift Types](http://thrift.apache.org/docs/types)   
  Examples of thrift idl u can find at idl folder of this project.

3. Generate Code:          
  Would u prefer C#? OK.
  ```
  thrift -r -strict --gen csharp -out ./src/csharp idl/dialog-service.thrift
  ```
  Or another languages (type ```thrift -help``` to get the list)   
  specified at namespace section of your idl.

  U can use generate.sh file at root forler of this project to ...   
  HA! GENERATE sources.


Enjoy with fast interfaces development!   


More examples [here](http://thrift.apache.org/tutorial)         
For ex., the same C# [here](http://thrift.apache.org/tutorial/cpp)             
