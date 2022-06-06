# import io
# with io.open('codes_r.txt', mode='r', encoding='cp1252') as f_in: # 1251
#     for line in f_in:
#         print(line)

import re
import json

pattern = re.compile(
    r'\+?(\d{1,3}[\s\-()]?)?(\d{3})[\s\-()]?(\d{3})[\s\-()]?(\d{2})[\s\-()]?(\d{2,3})')


num_lines = sum(1 for line in open(
    './html-example.txt', 'r', encoding='utf-8'))
lst = [[] for i in range(num_lines)]
# print(lst)
with open("./html-example.txt", 'r', encoding='utf-8') as fin:
    with open("./output1.txt", "w") as fout:
        for index, line in enumerate(fin):
            search = pattern.search(line)
            while search:
                print(
                    index,
                    f"{search.start()} {search.end()-1}",
                    line[search.start():search.end()].replace(" ", "").replace(
                        "-", "").replace("(", "").replace(")", "").replace("+", "").__len__(),
                    line[search.start():search.end()])
                fout.write(
                    f"{index} {search.start()} {search.end()-1} {line[search.start():search.end()]}\n")
                lst[index].append({
                    "start": search.start(),
                    "end": search.end()-1,
                    "str": line[search.start():search.end()],
                    "cstr": line[search.start():search.end()].replace(" ", "").replace("-", "").replace("(", "").replace(")", "").replace("+", "")
                })

                search = pattern.search(line, search.end())

# with open("RegexGenerator/data.json","w") as jf:
#     json.dump(lst, jf)
