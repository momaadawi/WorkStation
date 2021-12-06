## Chain of commands vs. custom program
you could imagine writing a simple pro‐
gram to do the same thing. For example, in Ruby, it might look something like this:
``` Ruby
counts = Hash.new(0)
File.open('/var/log/nginx/access.log') do |file|
    file.each do |line|
        url = line.split[6]
        counts[url] += 1
    end
end
top5 = counts.map{|url, count| [count, url] }.sort.reverse[0...5]
top5.each{|count, url| puts "#{count} #{url}
```
The sort utility in GNU Coreutils (Linux) automatically handles larger-than-
memory datasets by spilling to disk, and automatically parallelizes sorting across
multiple CPU cores [ 9]. This means that the simple chain of Unix commands above
easily scales to large datasets, without running out of memory. The bottleneck is
likely to be the rate at which the input file can be read from disk


## The Unix philosophy
It’s no coincidence that we were able to analyze a log file quite easily, using a chain of
commands like in the example above: this was in fact one of the key design ideas of
Unix

This approach — automation, rapid prototyping, incremental iteration, being
friendly to experimentation, and breaking down large projects into manageable
chunks — sounds remarkably like the Agile and DevOps movements of today. Sur‐
prisingly little has changed in four decades

A Unix shell like bash lets us easily compose these small programs into surprisingly
powerful data processing jobs. Even though many of these programs are written by
different groups of people, they can be joined together in flexible ways. What does
Unix do to enable this composability

### A uniform interface

### Separation of logic and wiring

the biggest limitation of Unix tools is that they run only on a single
machine — and that’s where tools like Hadoop come in